using Odev.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OdevString_TekInstance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var items = new List<TextFormatType>
            {
                new TextFormatType("Tümü Küçük Harf", FormatterType.LowerCase),
                new TextFormatType("Tümü Büyük Harf", FormatterType.UpperCase),
                new TextFormatType("Tümce Düzeni", FormatterType.Sentence),
                new TextFormatType("Her Sözcük Büyük Hafle Başlar", FormatterType.FirstWordUpper),
                new TextFormatType("Büyük Küçük Harf Dönüştür", FormatterType.SwitchCase),
            };
            cmbEdit.DataSource = items;
            cmbEdit.DisplayMember = nameof(TextFormatType.DisplayName);
        }

        private void cmbEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = (cmbEdit.SelectedItem as TextFormatType).Type;
            var formatter = new TextFormatter();
            txtText.Text = formatter.Format(txtText.Text, type);
        }
    }
}
