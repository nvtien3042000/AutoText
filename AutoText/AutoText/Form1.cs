using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoText
{
    public partial class Form1 : Form
    {

        StreamReader reader;
        StreamWriter writer;
        String keyWord = "";
        String value = "";
        int selectedRowIndex = 0;
        String line;

        public Form1()
        {
            InitializeComponent();
            setTable();
            MaximizeBox = false;
        }

        private void setTable()
        {
            reader = new StreamReader("Data.txt");
            dataGridView.Rows.Clear();
            while (true)
            {
                line = reader.ReadLine();
                if(line == null)
                {
                    reader.Close();
                    break;
                }
                this.dataGridView.Rows.Add(line.Split(':'));
            }
        }

        private void setKeyWord(String keyWord)
        {
            this.keyWord = keyWord;
        }

        private String getKeyWord()
        {
            return this.keyWord;
        }

        private void setValue(String value)
        {
            this.value = value;
        }

        private String getValue()
        {
            return this.value;
        }

        private void setSelectedRowIndex(int selectedRowIndex)
        {
            this.selectedRowIndex = selectedRowIndex;
        }

        private int getSelectedRowIndex()
        {
            return this.selectedRowIndex;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex >= 0)
            {
                this.keyWordTb.Text = this.dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                this.replaceTb.Text = this.dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                setKeyWord(this.dataGridView.Rows[rowIndex].Cells[0].Value.ToString());
                setValue(this.dataGridView.Rows[rowIndex].Cells[1].Value.ToString());
                setSelectedRowIndex(rowIndex);
            }
            
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            String key = keyWordTb.Text;
            String value = replaceTb.Text;
            if(key.Equals("") || value.Equals(""))
            {
                MessageBox.Show("You need to enter enough information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value.ToString().Equals(key))
                {
                    MessageBox.Show("The keyword has already existed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DataFile.saveRowInFile(key, value);
            dataGridView.Rows.Add(key, value);
            dataGridView.Sort(dataGridView.Columns[0], 0);
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            String beforeKey = getKeyWord();
            String beforeValue = getValue();
            String afterKey = keyWordTb.Text;
            String afterValue = replaceTb.Text;
            Console.WriteLine(beforeKey + "-" + beforeValue + "-" + afterKey + "-" + afterValue);
            DataFile.updateRowInFile(beforeKey, beforeValue, afterKey, afterValue);
            dataGridView.Rows[getSelectedRowIndex()].Cells[0].Value = afterKey;
            dataGridView.Rows[getSelectedRowIndex()].Cells[1].Value = afterValue;
            this.keyWordTb.Text = "";
            this.replaceTb.Text = "";
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            if(getSelectedRowIndex() >= 0)
            {
                DataFile.deleteRowInFile(getSelectedRowIndex());
                dataGridView.Rows.RemoveAt(getSelectedRowIndex());
                this.keyWordTb.Text = "";
                this.replaceTb.Text = "";
            }
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
