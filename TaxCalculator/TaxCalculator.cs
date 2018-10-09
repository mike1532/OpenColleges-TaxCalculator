/*
 * Open Colleges - Module 8 Part B Assessment - Tax Calculator
 * Author - Mike Ormond
 * 
 * The following source code can be used as a learning tool. Please do not submit as your own work.
 * 
 * ©2018
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TaxCalculator
{
    public partial class frmMain : Form
    {
        /*the following is to validate: 
            - a correct email address has been entered 
              (syntax taken from www.codeproject.com/Articles/22777/Email-Address-Validation-Using-Regular-Expression), 
            - correct employee ID has been entered
            - correct contractor ID has been entered*/

        Regex validEmail = new Regex(@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$");
        Regex validEmployeeID = new Regex(@"^[Ee][1-9][0-9]{3}$");
        Regex validContractorID = new Regex(@"^[Cc][1-9][0-9]{3}$");

        //declares global variables to allow access through multiple methods/places.
        private double salary;
        private double taxPayable;

        string nl = "\n";

        public frmMain()
        {
            InitializeComponent();
            HideHoursWorked();
            HideQuickFill(); //comment out to show quick fill buttons when running the program
        }

        private void txtHoursWorked_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            //sets max length of input to 5. Makes hours worked visible for contractors
            txtEmployeeID.MaxLength = 5;

            if (txtEmployeeID.Text.ToUpper().StartsWith("C"))
            {
                lblHoursWorked.Visible = true;
                txtHoursWorked.Visible = true;
            }
            else
            {
               HideHoursWorked();
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            //Creates new employee. Runs edit checks. Prints to display if successful
            Employee employee = new Employee();

            employee = employee.CreateEmployee(employee, txtEmployeeID.Text.ToUpper(), txtFirstName.Text, txtSurname.Text, comboBoxGender.Text,
                comboBoxDepartment.Text, txtEmail.Text, txtHourlyRate.Text);

            if (CheckInput() == false)
            {
               if (validEmployeeID.IsMatch(txtEmployeeID.Text) && CheckInput() == false)
                {
                    txtDisplay.Clear();
                    txtDisplay.Text = "Employee Created!" + Environment.NewLine + Environment.NewLine;
                    txtDisplay.Text += "Employee ID: " + employee.EmployeeID + Environment.NewLine;
                    txtDisplay.Text += "First Name: " + employee.FirstName + Environment.NewLine;
                    txtDisplay.Text += "Surname: " + employee.Surname + Environment.NewLine;
                    txtDisplay.Text += "Gender: " + employee.Gender + Environment.NewLine;
                    txtDisplay.Text += "Department: " + employee.Department + Environment.NewLine;
                    txtDisplay.Text += "Email: " + employee.Email + Environment.NewLine;
                    txtDisplay.Text += "Hourly Rate: $" + employee.HourlyRate + Environment.NewLine;
                }
                else
                    if (!validEmployeeID.IsMatch(txtEmployeeID.Text))
                    {
                        MessageBox.Show("Invalid Employee ID\nPlease make sure the Employee ID is in the correct format\n" + nl + "(Employee ID must begin with an E for Full-Time Employee or a C for Contractor followed by a four digit number that is greater than 1000)");
                    }
            }
        }

        private void btnCreateContactor_Click(object sender, EventArgs e)
        {
            //Creates contractor. Runs edit checks. Prints to display if successful
            Contractor contractor = new Contractor();

            contractor = contractor.CreateContractor(contractor, txtEmployeeID.Text.ToUpper(), txtFirstName.Text, txtSurname.Text, comboBoxGender.Text,
                comboBoxDepartment.Text, txtEmail.Text, txtHourlyRate.Text, txtHoursWorked.Text);

            if (CheckInput() == false)
            { 
                if (validContractorID.IsMatch(txtEmployeeID.Text) && CheckContractorInput() == false)
                    {
                        txtDisplay.Clear();
                        txtDisplay.Text = "Contractor Created!" + Environment.NewLine + Environment.NewLine;
                        txtDisplay.Text += "Employee ID: " + contractor.EmployeeID + Environment.NewLine;
                        txtDisplay.Text += "First Name: " + contractor.FirstName + Environment.NewLine;
                        txtDisplay.Text += "Surname: " + contractor.Surname + Environment.NewLine;
                        txtDisplay.Text += "Gender: " + contractor.Gender + Environment.NewLine;
                        txtDisplay.Text += "Department: " + contractor.Department + Environment.NewLine;
                        txtDisplay.Text += "Email: " + contractor.Email + Environment.NewLine;
                        txtDisplay.Text += "Hourly Rate: $" + contractor.HourlyRate + Environment.NewLine;
                        txtDisplay.Text += "Hours Worked: " + contractor.HoursWorked + Environment.NewLine;
                    }
                else      
                    if (!validContractorID.IsMatch(txtEmployeeID.Text))
                        {
                             MessageBox.Show("Invalid Employee ID\nPlease make sure the Employee ID is in the correct format\n" + nl + "(Employee ID must begin with an E for Full-Time Employee or a C for Contractor followed by a four digit number that is greater than 1000)");
                        }
            }
        }

        private void btnEmployeeTaxPayable_Click(object sender, EventArgs e)
        {
            //checks that all fields have been entered before creating PDF.
            if (!validEmployeeID.IsMatch(txtEmployeeID.Text))
            {
                MessageBox.Show("Invalid Employee ID\nPlease Make sure the Employee ID is in the correct format\n (E#### for Full-Time Employee or C#### for Contractor)");
            }

            if (validEmployeeID.IsMatch(txtEmployeeID.Text) && CheckInput() == false)
            {
                //finds rates.txt path and places it into a StreamReader object
                string ratesFilePath = System.IO.Path.GetFullPath("rates.txt");
                StreamReader SR = new StreamReader(ratesFilePath);

                //places each line (2 total) from rates.txt into a string. To read multiple lines in text file
                //one could perform a for loop to save writing the same lines of code over and over again.
                string income = SR.ReadLine();
                string tax = SR.ReadLine();

                //takes the corresponding strings and places it into a string array. Parses string arrays
                //to int and double array

                string[] brackets = income.Split(',');
                string[] rates = tax.Split(',');
                int[] incomeBracket = Array.ConvertAll(brackets, int.Parse);
                double[] taxRate = Array.ConvertAll(rates, double.Parse);

                //Once could place the set tax amounts to an array. But by doing it this way you 
                //would only have to amend the tax rates in the rates.txt file if there was 
                //any change. **Don't Repeat Yourself**
                double fourthAmount = (incomeBracket[3] - incomeBracket[2]) * taxRate[3];
                double thirdAmount = (incomeBracket[2] - incomeBracket[1]) * taxRate[2];
                double secondAmount = (incomeBracket[1] - incomeBracket[0]) * taxRate[1];
                double firstAmount = incomeBracket[0] * taxRate[0];
                                
                salary = double.Parse(txtHourlyRate.Text) * Employee.HRS_WORK_WEEK;                
                
                if(salary <= incomeBracket[0])
                {
                    taxPayable = salary * taxRate[0];
                }
                if(salary > incomeBracket[0] && salary <= incomeBracket[1])
                {
                    secondAmount = (salary - incomeBracket[0]) * taxRate[1];
                    taxPayable = firstAmount + secondAmount;
                }
                if(salary > incomeBracket[1] && salary <= incomeBracket[2])
                {
                    thirdAmount = (salary - incomeBracket[1]) * taxRate[2];                    
                    taxPayable = firstAmount + secondAmount + thirdAmount;
                }
                if(salary > incomeBracket[2] && salary <= incomeBracket[3])
                {
                    fourthAmount = (salary - incomeBracket[2]) * taxRate[3];                    
                    taxPayable = firstAmount + secondAmount + thirdAmount + fourthAmount;
                }
                if(salary > incomeBracket[3] && salary <= incomeBracket[4] || salary > incomeBracket[4])
                {
                    double fifthAmount = (salary - incomeBracket[3]) * taxRate[4];                    
                    taxPayable = firstAmount + secondAmount + thirdAmount + fourthAmount + fifthAmount;
                }
                PrintInfo();
                CreatePdf();                
            }  
        }

        private void btnContractorTaxPayable_Click(object sender, EventArgs e)
        {
            //checks that all fields have been filled before creating PDF.
            if (!validContractorID.IsMatch(txtEmployeeID.Text))
            {
                MessageBox.Show("Invalid Employee ID\nPlease Make sure the Employee ID is in the correct format\n (E#### for Full-Time Employee or C#### for Contractor)");
            }

            if (validContractorID.IsMatch(txtEmployeeID.Text) && CheckInput() == false)
                if (CheckContractorInput() == false)
                {
                    //turns hourlyRate & hoursWorked data into type double to perform taxPayable equation
                    salary = double.Parse(txtHourlyRate.Text) * double.Parse(txtHoursWorked.Text);
                    taxPayable = salary * Contractor.TAX_RATE;
                                        
                    PrintInfo();
                    CreatePdf();
                }
        }

        //Quick Fill buttons and HideQuickFill method to remove buttons
        private void btnQuickFillEmployee_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Text = "E1234";
            txtFirstName.Text = "Francis";
            txtSurname.Text = "Gord";
            comboBoxGender.Text = "Male";
            comboBoxDepartment.Text = "IT";
            txtEmail.Text = "F.Gord@gmail.com";
            txtHourlyRate.Text = "42.50";
        }

        private void btnQuickFillContractor_Click(object sender, EventArgs e)
        {

            txtEmployeeID.Text = "C5678";
            txtFirstName.Text = "Jenny";
            txtSurname.Text = "Pence";
            comboBoxGender.Text = "Female";
            comboBoxDepartment.Text = "Customer Service";
            txtEmail.Text = "J_rocks_4eva@hotmail.com";
            txtHourlyRate.Text = "35";
            txtHoursWorked.Text = "55";
        }

        private void HideQuickFill()
        {
            btnQuickFillEmployee.Visible = false;
            btnQuickFillContractor.Visible = false;
        }

        //hides hours worked from program start.
        private void HideHoursWorked()
        {
            lblHoursWorked.Visible = false;
            txtHoursWorked.Visible = false;
        }

        //checks that all fields (except hours worked) have been filled and have appropriate data
        //before printing to display.
        private bool CheckInput()
        {

            if (txtEmployeeID.Text == String.Empty)
            {
                MessageBox.Show("Please enter an Employee ID");
                return true;
            }
            else if (txtFirstName.Text == String.Empty)
            {
                MessageBox.Show("Please enter the Employee's First Name");
                return true;
            }
            else if (txtSurname.Text == String.Empty)
            {
                MessageBox.Show("Please enter the Employee's Surname");
                return true;
            }
            else if (comboBoxGender.Text == String.Empty)
            {
                MessageBox.Show("Please enter the Employee's gender");
                return true;
            }
            else if (comboBoxDepartment.Text == String.Empty)
            {
                MessageBox.Show("Please choose the Employee's department");
                return true;
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Please enter the Employee's email address");
                return true;
            }
            else if (!validEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address");
                return true;
            }
            else if (txtHourlyRate.Text == "")
            {
                MessageBox.Show("Please enter the Employee's hourly rate");
                return true;
            }
            else if (!double.TryParse(txtHourlyRate.Text, out double HourlyRate))
            {
                MessageBox.Show("Please check the hourly rate field. This is a number field only");
                return true;

            }
            return false;
        }

        //checks hours worked for contractor has correct data type/been entered.
        private bool CheckContractorInput()
        {
            if (txtHoursWorked.Text == String.Empty)
            {
                MessageBox.Show("Please enter hours worked");
                return true;
            }
            else if (!double.TryParse(txtHoursWorked.Text, out double HoursWorked))
            {
                MessageBox.Show("Please check the hours worked field. This is a number field only");
                return true;
            }
            else
                return false;
        } 
              
        //creates pdf
        private void CreatePdf()
        {           
            //sets default options for save file
            saveFileDialog1.FileName = "Tax Report for " + txtFirstName.Text + " " + txtSurname.Text;
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.ShowDialog();

            /*- create FileStream object (fs) with pdf name, mode type, access type, and if it can be shared 
              - create new document object (A4 page size)
              - create a iTextSharp.text.pdf.PdfWriter object, it helps to write the Document to the Specified
                FileStream 
              - open document
              - add paragraph
              - close document*/
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            doc.Add(new Paragraph("TAX REPORT" + nl + nl + "Employee ID: " + txtEmployeeID.Text + nl + "Name: " + txtFirstName.Text + " " + txtSurname.Text + nl +
                    "Department: " + comboBoxDepartment.Text + nl + "Salary: $" + salary.ToString() + nl + "Tax Payable: $" + taxPayable.ToString()));
            doc.Close();
        }

        //print Info
        private void PrintInfo()
        {
            //shows user what info will be saved to the PDF
            txtDisplay.Clear();
            txtDisplay.Text += "/////Information shown will be saved to PDF/////" + Environment.NewLine + Environment.NewLine;
            txtDisplay.Text += "Employee ID: " + txtEmployeeID.Text + Environment.NewLine;
            txtDisplay.Text += "Name: " + txtFirstName.Text + " " + txtSurname.Text + Environment.NewLine;
            txtDisplay.Text += "Department: " + comboBoxDepartment.Text + Environment.NewLine;
            txtDisplay.Text += "Salary: $" + salary.ToString() + Environment.NewLine;
            txtDisplay.Text += "Tax Payable: $" + taxPayable.ToString() + Environment.NewLine;
        }
        
 
    }
}
