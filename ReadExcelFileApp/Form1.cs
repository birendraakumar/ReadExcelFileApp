using IronXL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Spire.Doc;

namespace ReadExcelFileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file
            if (file.ShowDialog() == DialogResult.OK) //if there is a file chosen by the user
            {
                string fileExt = Path.GetExtension(file.FileName); //get the file extension
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = ReadExcel(file.FileName); //read excel file
                        dataGrdView.Visible = true;
                        dataGrdView.DataSource = dtExcel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private DataTable ReadExcel(string fileName)
        {
            WorkBook workbook = WorkBook.Load(fileName);
            WorkSheet sheet = workbook.DefaultWorkSheet;
            return sheet.ToDataTable(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int FileCounter = 1;

            foreach (DataGridViewRow row in dataGrdView.Rows)
            {
                Document doc = new Document();
                doc.LoadFromFile("C:\\Users\\HP\\Desktop\\Back_Format.docx");

                doc.Replace("{{@DOCTORNAME}}", Convert.ToString(row.Cells[0].Value), true, true);
                doc.Replace("{{@NPI}}", Convert.ToString(row.Cells[1].Value), true, true);
                doc.Replace("{{@ADDRESS}}", Convert.ToString(row.Cells[2].Value), true, true);
                doc.Replace("{{@PHONENUMBER}}", Convert.ToString(row.Cells[3].Value), true, true);

                doc.Replace("{{@PATIENT_NAME}}", Convert.ToString(row.Cells[9].Value), true, true);
                doc.Replace("{{@ADDRESS1}}", Convert.ToString(row.Cells[10].Value), true, true);
                doc.Replace("{{@ADDRESS2}}", 
                    Convert.ToString(row.Cells[11].Value) + " " 
                    + Convert.ToString(row.Cells[12].Value) + " " 
                    + Convert.ToString(row.Cells[13].Value), true, true);
                doc.Replace("{{@PATIENTPHONE}}", Convert.ToString(row.Cells[14].Value), true, true);
                doc.Replace("{{@PATIENTHEIGHT}}", Convert.ToString(row.Cells[15].Value), true, true);
                doc.Replace("{{@PATIENTWEIGHT}}", Convert.ToString(row.Cells[16].Value), true, true);
                doc.Replace("{{@PATIENTDOB}}", Convert.ToString(row.Cells[17].Value), true, true);
                doc.Replace("{{@PATENTGENDER}}", Convert.ToString(row.Cells[18].Value), true, true);

                doc.Replace("{{@MEDICARE}}", Convert.ToString(row.Cells[21].Value), true, true);
                doc.Replace("{{@WAISTSIZE}}", Convert.ToString(row.Cells[22].Value), true, true);
                doc.Replace("{{@TREATMENTS}}", Convert.ToString(row.Cells[25].Value), true, true);
                doc.Replace("{{@LEVELOFPAIN}}", Convert.ToString(row.Cells[23].Value), true, true);
                doc.Replace("{{@EXPERIENCINGTHEPAIN}}", Convert.ToString(row.Cells[24].Value), true, true);
                doc.Replace("{{@SURGERY}}", Convert.ToString(row.Cells[28].Value), true, true);

                doc.Replace("{{@DATE}}", Convert.ToString(row.Cells[6].Value), true, true);
                doc.Replace("{{@FULLTIMESTAMP}}", Convert.ToString(row.Cells[8].Value), true, true);
                doc.Replace("{{@noun}}", Convert.ToString(row.Cells[19].Value), true, true);
                doc.Replace("{{@Noun}}", Convert.ToString(row.Cells[20].Value), true, true);
                doc.Replace("{{@AGGRAVATE}}", Convert.ToString(row.Cells[27].Value), true, true);

                string newFolder = "Report";

                string path = System.IO.Path.Combine(
                   Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                   newFolder
                );

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string FileName = path + "\\" + FileCounter + ".pdf";

                doc.SaveToFile(FileName, FileFormat.PDF);

                FileCounter++;
                /**************************************************************/
            }
        }
    }
}