using Aspose.Cells;
using System;

namespace ReadExcelFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "C:\\Users\\ssd\\Desktop\\employees.xlsx";
            Workbook wb = new Workbook(filename);
            Worksheet sheet = wb.Worksheets[0];

            //Save the Excel file.



            char column1 = 'B';
            char column2 = 'C';
            char column3 = 'D';
            char column4 = 'E';
            char column5 = 'F';
            int row = 4;
            Cell cell1 = sheet.Cells[$"{column1}{row}"];
            Cell cell2= sheet.Cells[$"{column2}{row}"];
            Cell cell3 = sheet.Cells[$"{column3}{row}"];
            Cell cell4 = sheet.Cells[$"{column4}{row}"];
            Cell cell5 = sheet.Cells[$"{column5}{row}"];
            while (cell1.Value != null)
            {
                Console.WriteLine(cell1.Value);
                Console.WriteLine(cell2.Value);
                Console.WriteLine(cell3.Value);
                Console.WriteLine(cell4.Value);
                Console.WriteLine(cell5.Value);

                row++;
                 cell1 = sheet.Cells[$"{column1}{row}"];
                 cell2 = sheet.Cells[$"{column2}{row}"];
                 cell3 = sheet.Cells[$"{column3}{row}"];
                 cell4 = sheet.Cells[$"{column4}{row}"];
                 cell5 = sheet.Cells[$"{column5}{row}"];
            }
            wb.Save("MyBook.xlsx", SaveFormat.Xlsx);

        }

        
    }
}
