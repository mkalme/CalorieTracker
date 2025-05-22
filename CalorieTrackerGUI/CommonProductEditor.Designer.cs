
namespace CalorieTrackerGUI {
    partial class CommonProductEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // TableContainer
            // 
            this.TableContainer.ColumnCount = 1;
            this.TableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableContainer.Location = new System.Drawing.Point(0, 0);
            this.TableContainer.Name = "TableContainer";
            this.TableContainer.Padding = new System.Windows.Forms.Padding(10);
            this.TableContainer.RowCount = 2;
            this.TableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableContainer.Size = new System.Drawing.Size(412, 274);
            this.TableContainer.TabIndex = 0;
            // 
            // CommonProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(412, 274);
            this.Controls.Add(this.TableContainer);
            this.Name = "CommonProductEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommonProductEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableContainer;
    }
}