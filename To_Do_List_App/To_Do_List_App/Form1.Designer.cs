
namespace To_Do_List_App
{
    partial class ToDoListEnC
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToDoList = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ToDoListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ToDoList
            // 
            this.ToDoList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToDoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoList.Location = new System.Drawing.Point(12, 21);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.Size = new System.Drawing.Size(1422, 57);
            this.ToDoList.TabIndex = 0;
            this.ToDoList.Text = "To Do List en C";
            this.ToDoList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToDoList.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 114);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(1422, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 173);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(1422, 20);
            this.DescriptionTextBox.TabIndex = 2;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptiontextBox_TextChanged);
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(9, 146);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(1425, 24);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description :";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(8, 87);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1426, 24);
            this.Title.TabIndex = 4;
            this.Title.Text = "Title :";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 209);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(340, 40);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(374, 209);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(340, 40);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(733, 209);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(340, 40);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1094, 209);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(340, 40);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ToDoListView
            // 
            this.ToDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToDoListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoListView.Location = new System.Drawing.Point(12, 255);
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.Size = new System.Drawing.Size(1422, 287);
            this.ToDoListView.TabIndex = 9;
            // 
            // ToDoListEnC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1439, 554);
            this.Controls.Add(this.ToDoListView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.ToDoList);
            this.Name = "ToDoListEnC";
            this.Text = "To Do List en C";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ToDoList;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView ToDoListView;
    }
}

