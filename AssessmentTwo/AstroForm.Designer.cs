
namespace AssessmentTwo
{
    partial class AstroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonRange = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonMode = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonSequentialSearch = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.ToolTip(this.components);
            this.delete = new System.Windows.Forms.ToolTip(this.components);
            this.edit = new System.Windows.Forms.ToolTip(this.components);
            this.Sssort = new System.Windows.Forms.ToolTip(this.components);
            this.bSearch = new System.Windows.Forms.ToolTip(this.components);
            this.sSearch = new System.Windows.Forms.ToolTip(this.components);
            this.text = new System.Windows.Forms.ToolTip(this.components);
            this.auto = new System.Windows.Forms.ToolTip(this.components);
            this.Mid = new System.Windows.Forms.ToolTip(this.components);
            this.mode = new System.Windows.Forms.ToolTip(this.components);
            this.average = new System.Windows.Forms.ToolTip(this.components);
            this.range = new System.Windows.Forms.ToolTip(this.components);
            this.List = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxMedium = new System.Windows.Forms.TextBox();
            this.textBoxMode = new System.Windows.Forms.TextBox();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(68, 66);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.add.SetToolTip(this.buttonAdd, "Click to add element to the list box");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(68, 106);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.delete.SetToolTip(this.buttonDelete, "Click to delete element form listbox");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(68, 146);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.edit.SetToolTip(this.buttonEdit, "Click to edit the element in the listbox");
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 224);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(131, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Binary Search";
            this.bSearch.SetToolTip(this.buttonSearch, "Click to search an intger by binary search");
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(68, 186);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Sort";
            this.Sssort.SetToolTip(this.buttonSort, "click to sort the listbox");
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(158, 44);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(153, 355);
            this.listBox.TabIndex = 5;
            this.List.SetToolTip(this.listBox, "Displays the intgers ");
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(158, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(153, 20);
            this.textBox.TabIndex = 6;
            this.text.SetToolTip(this.textBox, "Click to type ");
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(355, 12);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(75, 23);
            this.buttonFill.TabIndex = 7;
            this.buttonFill.Text = "Auto Fill";
            this.auto.SetToolTip(this.buttonFill, "Click to auto fill the listbox with random intger");
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonRange
            // 
            this.buttonRange.Location = new System.Drawing.Point(329, 186);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(76, 23);
            this.buttonRange.TabIndex = 8;
            this.buttonRange.Text = "Range";
            this.range.SetToolTip(this.buttonRange, "Click the find the range in the listbox");
            this.buttonRange.UseVisualStyleBackColor = true;
            this.buttonRange.Click += new System.EventHandler(this.buttonRange_Click);
            // 
            // buttonMedium
            // 
            this.buttonMedium.Location = new System.Drawing.Point(330, 66);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(75, 23);
            this.buttonMedium.TabIndex = 9;
            this.buttonMedium.Text = "Medium";
            this.Mid.SetToolTip(this.buttonMedium, "Click to find the midium number in the listbox ");
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // buttonMode
            // 
            this.buttonMode.Location = new System.Drawing.Point(329, 106);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(75, 23);
            this.buttonMode.TabIndex = 10;
            this.buttonMode.Text = "Mode";
            this.mode.SetToolTip(this.buttonMode, "Click to find the most recurring intger in the listbox");
            this.buttonMode.UseVisualStyleBackColor = true;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(329, 146);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(75, 23);
            this.buttonAverage.TabIndex = 11;
            this.buttonAverage.Text = "Average";
            this.average.SetToolTip(this.buttonAverage, "Click to find the average intger in the listbox");
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // buttonSequentialSearch
            // 
            this.buttonSequentialSearch.Location = new System.Drawing.Point(12, 262);
            this.buttonSequentialSearch.Name = "buttonSequentialSearch";
            this.buttonSequentialSearch.Size = new System.Drawing.Size(131, 23);
            this.buttonSequentialSearch.TabIndex = 12;
            this.buttonSequentialSearch.Text = "Sequential Search";
            this.sSearch.SetToolTip(this.buttonSequentialSearch, "Click to search an intger by sequential search");
            this.buttonSequentialSearch.UseVisualStyleBackColor = true;
            this.buttonSequentialSearch.Click += new System.EventHandler(this.buttonSequentialSearch_Click);
            // 
            // add
            // 
            this.add.ToolTipTitle = "Add";
            // 
            // delete
            // 
            this.delete.ToolTipTitle = "Delete";
            // 
            // edit
            // 
            this.edit.ToolTipTitle = "Edit";
            // 
            // Sssort
            // 
            this.Sssort.ToolTipTitle = "Sort";
            // 
            // bSearch
            // 
            this.bSearch.ToolTipTitle = "Binary Search";
            // 
            // sSearch
            // 
            this.sSearch.ToolTipTitle = "Sequential Search";
            // 
            // text
            // 
            this.text.ToolTipTitle = "Textbox ";
            // 
            // auto
            // 
            this.auto.ToolTipTitle = "Auto Fill";
            // 
            // Mid
            // 
            this.Mid.ToolTipTitle = "Medium";
            // 
            // mode
            // 
            this.mode.ToolTipTitle = "Mode";
            // 
            // average
            // 
            this.average.ToolTipTitle = "Average";
            // 
            // range
            // 
            this.range.ToolTipTitle = "Range";
            // 
            // List
            // 
            this.List.ToolTipTitle = "ListBox";
            // 
            // textBoxMedium
            // 
            this.textBoxMedium.Location = new System.Drawing.Point(423, 66);
            this.textBoxMedium.Name = "textBoxMedium";
            this.textBoxMedium.Size = new System.Drawing.Size(50, 20);
            this.textBoxMedium.TabIndex = 13;
            // 
            // textBoxMode
            // 
            this.textBoxMode.Location = new System.Drawing.Point(423, 109);
            this.textBoxMode.Name = "textBoxMode";
            this.textBoxMode.Size = new System.Drawing.Size(50, 20);
            this.textBoxMode.TabIndex = 14;
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(423, 149);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.Size = new System.Drawing.Size(50, 20);
            this.textBoxAverage.TabIndex = 15;
            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(423, 189);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(50, 20);
            this.textBoxRange.TabIndex = 16;
            // 
            // AstroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 428);
            this.Controls.Add(this.textBoxRange);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.textBoxMode);
            this.Controls.Add(this.textBoxMedium);
            this.Controls.Add(this.buttonSequentialSearch);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.buttonMedium);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AstroForm";
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonRange;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonSequentialSearch;
        private System.Windows.Forms.ToolTip add;
        private System.Windows.Forms.ToolTip delete;
        private System.Windows.Forms.ToolTip edit;
        private System.Windows.Forms.ToolTip bSearch;
        private System.Windows.Forms.ToolTip Sssort;
        private System.Windows.Forms.ToolTip List;
        private System.Windows.Forms.ToolTip text;
        private System.Windows.Forms.ToolTip auto;
        private System.Windows.Forms.ToolTip range;
        private System.Windows.Forms.ToolTip Mid;
        private System.Windows.Forms.ToolTip mode;
        private System.Windows.Forms.ToolTip average;
        private System.Windows.Forms.ToolTip sSearch;
        private System.Windows.Forms.TextBox textBoxMedium;
        private System.Windows.Forms.TextBox textBoxMode;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.TextBox textBoxRange;
    }
}

