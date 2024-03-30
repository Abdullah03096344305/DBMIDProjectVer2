using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ver2.Forms
{
    public partial class FormGenerateReport : Form
    {
        public FormGenerateReport()
        {
            InitializeComponent();
        }

        public class PDFGenerator
        {
            public void GeneratePDF(string query, string outputPath)
            {
                try
                {
                   
                    string connectionString = "Server=DESKTOP-GSR1O2M;Database=MidProject;Integrated Security=True;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                      
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        
                        Document document = new Document();
                        PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));
                        document.Open();

                        PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            pdfTable.AddCell(new Phrase(column.ColumnName));
                        }
                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (var cell in row.ItemArray)
                            {
                                pdfTable.AddCell(new Phrase(cell.ToString()));
                            }
                        }
                        document.Add(pdfTable);

                        document.Close();
                    }
                    MessageBox.Show("PDF generated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string query = QueryTextBox.Text;
            string fileName = textBox1.Text;
            string directoryPath = "D:\\UET\\4th_Semester\\DB-LAB\\MID-Project\\"; 

            
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string outputPath = Path.Combine(directoryPath, fileName + ".pdf");

            PDFGenerator pdfGenerator = new PDFGenerator();
            pdfGenerator.GeneratePDF(query, outputPath);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
