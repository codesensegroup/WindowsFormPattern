
namespace WinFormMVC.View
{
    partial class ViewForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Incvalue = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_OnReduce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Incvalue
            // 
            this.btn_Incvalue.Location = new System.Drawing.Point(142, 12);
            this.btn_Incvalue.Name = "btn_Incvalue";
            this.btn_Incvalue.Size = new System.Drawing.Size(130, 22);
            this.btn_Incvalue.TabIndex = 0;
            this.btn_Incvalue.Text = "Incvalue";
            this.btn_Incvalue.UseVisualStyleBackColor = true;
            this.btn_Incvalue.Click += new System.EventHandler(this.btn_Incvalue_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(12, 27);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(124, 22);
            this.txt_Result.TabIndex = 1;
            this.txt_Result.Text = "0";
            // 
            // btn_OnReduce
            // 
            this.btn_OnReduce.Location = new System.Drawing.Point(142, 40);
            this.btn_OnReduce.Name = "btn_OnReduce";
            this.btn_OnReduce.Size = new System.Drawing.Size(130, 22);
            this.btn_OnReduce.TabIndex = 2;
            this.btn_OnReduce.Text = "OnReduce(use delegate)";
            this.btn_OnReduce.UseVisualStyleBackColor = true;
            this.btn_OnReduce.Click += new System.EventHandler(this.btn_OnReduce_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.btn_OnReduce);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_Incvalue);
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Incvalue;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_OnReduce;
    }
}

