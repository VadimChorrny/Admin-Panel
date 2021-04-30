
namespace WindowsFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.tbCaptionChild = new System.Windows.Forms.TextBox();
            this.cbColors = new System.Windows.Forms.ComboBox();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.btnSetText = new System.Windows.Forms.Button();
            this.btnOverloadShow = new System.Windows.Forms.Button();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.lblInfoChild = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(285, 125);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(255, 49);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tbCaptionChild
            // 
            this.tbCaptionChild.Location = new System.Drawing.Point(285, 22);
            this.tbCaptionChild.Multiline = true;
            this.tbCaptionChild.Name = "tbCaptionChild";
            this.tbCaptionChild.Size = new System.Drawing.Size(255, 26);
            this.tbCaptionChild.TabIndex = 1;
            // 
            // cbColors
            // 
            this.cbColors.FormattingEnabled = true;
            this.cbColors.Location = new System.Drawing.Point(285, 82);
            this.cbColors.Name = "cbColors";
            this.cbColors.Size = new System.Drawing.Size(255, 24);
            this.cbColors.TabIndex = 2;
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(285, 195);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(255, 49);
            this.btnShowDialog.TabIndex = 3;
            this.btnShowDialog.Text = "Show Dialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // btnSetText
            // 
            this.btnSetText.Location = new System.Drawing.Point(285, 330);
            this.btnSetText.Name = "btnSetText";
            this.btnSetText.Size = new System.Drawing.Size(255, 49);
            this.btnSetText.TabIndex = 5;
            this.btnSetText.Text = "Set Text";
            this.btnSetText.UseVisualStyleBackColor = true;
            // 
            // btnOverloadShow
            // 
            this.btnOverloadShow.Location = new System.Drawing.Point(285, 260);
            this.btnOverloadShow.Name = "btnOverloadShow";
            this.btnOverloadShow.Size = new System.Drawing.Size(255, 49);
            this.btnOverloadShow.TabIndex = 4;
            this.btnOverloadShow.Text = "Overload Show";
            this.btnOverloadShow.UseVisualStyleBackColor = true;
            this.btnOverloadShow.Click += new System.EventHandler(this.btnOverloadShow_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Location = new System.Drawing.Point(285, 407);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(255, 31);
            this.btnCloseAll.TabIndex = 6;
            this.btnCloseAll.Text = "Close All Window";
            this.btnCloseAll.UseVisualStyleBackColor = true;
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // lblInfoChild
            // 
            this.lblInfoChild.AutoSize = true;
            this.lblInfoChild.Location = new System.Drawing.Point(51, 41);
            this.lblInfoChild.Name = "lblInfoChild";
            this.lblInfoChild.Size = new System.Drawing.Size(104, 17);
            this.lblInfoChild.TabIndex = 7;
            this.lblInfoChild.Text = "Info about child";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.lblInfoChild);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.btnSetText);
            this.Controls.Add(this.btnOverloadShow);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.cbColors);
            this.Controls.Add(this.tbCaptionChild);
            this.Controls.Add(this.btnShow);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tbCaptionChild;
        private System.Windows.Forms.ComboBox cbColors;
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnSetText;
        private System.Windows.Forms.Button btnOverloadShow;
        private System.Windows.Forms.Button btnCloseAll;
        protected internal System.Windows.Forms.Label lblInfoChild;
    }
}

