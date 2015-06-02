namespace Bacon
{
    partial class Bacon
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bacon));
            this.T_decoded = new System.Windows.Forms.TextBox();
            this.T_encoded = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.Button();
            this.Decode = new System.Windows.Forms.Button();
            this.Mask = new System.Windows.Forms.Button();
            this.Demask = new System.Windows.Forms.Button();
            this.T_Mask = new System.Windows.Forms.TextBox();
            this.Info_prog = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.MenuStrip();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Default_text = new System.Windows.Forms.ToolStripMenuItem();
            this.Alphavit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // T_decoded
            // 
            this.T_decoded.HideSelection = false;
            this.T_decoded.Location = new System.Drawing.Point(12, 47);
            this.T_decoded.Multiline = true;
            this.T_decoded.Name = "T_decoded";
            this.T_decoded.Size = new System.Drawing.Size(511, 165);
            this.T_decoded.TabIndex = 3;
            this.T_decoded.Text = "Decoded text";
            // 
            // T_encoded
            // 
            this.T_encoded.Location = new System.Drawing.Point(12, 238);
            this.T_encoded.Multiline = true;
            this.T_encoded.Name = "T_encoded";
            this.T_encoded.Size = new System.Drawing.Size(511, 185);
            this.T_encoded.TabIndex = 2;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(12, 429);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(250, 23);
            this.Code.TabIndex = 4;
            this.Code.Text = "Зашифровать";
            this.Code.UseVisualStyleBackColor = true;
            this.Code.Click += new System.EventHandler(this.Code_Click);
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(273, 429);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(250, 23);
            this.Decode.TabIndex = 5;
            this.Decode.Text = "Расшифровать";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // Mask
            // 
            this.Mask.Location = new System.Drawing.Point(529, 429);
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(250, 23);
            this.Mask.TabIndex = 6;
            this.Mask.Text = "Скрыть шифрование";
            this.Mask.UseVisualStyleBackColor = true;
            this.Mask.Click += new System.EventHandler(this.Mask_Click);
            // 
            // Demask
            // 
            this.Demask.Location = new System.Drawing.Point(790, 429);
            this.Demask.Name = "Demask";
            this.Demask.Size = new System.Drawing.Size(250, 23);
            this.Demask.TabIndex = 7;
            this.Demask.Text = "Раскрыть шифрование";
            this.Demask.UseVisualStyleBackColor = true;
            this.Demask.Click += new System.EventHandler(this.Demask_Click);
            // 
            // T_Mask
            // 
            this.T_Mask.Location = new System.Drawing.Point(529, 47);
            this.T_Mask.Multiline = true;
            this.T_Mask.Name = "T_Mask";
            this.T_Mask.Size = new System.Drawing.Size(511, 376);
            this.T_Mask.TabIndex = 8;
            this.T_Mask.Text = resources.GetString("T_Mask.Text");
            this.T_Mask.TextChanged += new System.EventHandler(this.T_Mask_TextChanged);
            // 
            // Info_prog
            // 
            this.Info_prog.Name = "Info_prog";
            this.Info_prog.Size = new System.Drawing.Size(103, 20);
            this.Info_prog.Text = "О программе...";
            this.Info_prog.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Info
            // 
            this.Info.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help,
            this.Info_prog,
            this.Default_text});
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(1042, 24);
            this.Info.TabIndex = 9;
            this.Info.Text = "О программе";
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шифрованиеToolStripMenuItem,
            this.расшифрованиеToolStripMenuItem});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(68, 20);
            this.Help.Text = "Помощь";
            // 
            // шифрованиеToolStripMenuItem
            // 
            this.шифрованиеToolStripMenuItem.Name = "шифрованиеToolStripMenuItem";
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            this.шифрованиеToolStripMenuItem.Click += new System.EventHandler(this.шифрованиеToolStripMenuItem_Click);
            // 
            // расшифрованиеToolStripMenuItem
            // 
            this.расшифрованиеToolStripMenuItem.Name = "расшифрованиеToolStripMenuItem";
            this.расшифрованиеToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.расшифрованиеToolStripMenuItem.Text = "Расшифрование";
            this.расшифрованиеToolStripMenuItem.Click += new System.EventHandler(this.расшифрованиеToolStripMenuItem_Click);
            // 
            // Default_text
            // 
            this.Default_text.Name = "Default_text";
            this.Default_text.Size = new System.Drawing.Size(199, 20);
            this.Default_text.Text = "Восстановить стандартный текст";
            this.Default_text.Click += new System.EventHandler(this.восстановитьСтарыйТекстToolStripMenuItem_Click);
            // 
            // Alphavit
            // 
            this.Alphavit.Location = new System.Drawing.Point(10, 480);
            this.Alphavit.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.Alphavit.Multiline = true;
            this.Alphavit.Name = "Alphavit";
            this.Alphavit.ReadOnly = true;
            this.Alphavit.Size = new System.Drawing.Size(511, 84);
            this.Alphavit.TabIndex = 24;
            this.Alphavit.TabStop = false;
            this.Alphavit.Text = resources.GetString("Alphavit.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(196, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Алфавит замены:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(529, 480);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(508, 84);
            this.textBox1.TabIndex = 26;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(631, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Алгоритм сокрытия сообщения в тесте:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Сообщение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Закодированное сообщение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(528, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Скрытое в тексте сообщение:";
            // 
            // Bacon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1042, 618);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alphavit);
            this.Controls.Add(this.T_Mask);
            this.Controls.Add(this.Demask);
            this.Controls.Add(this.Mask);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.T_decoded);
            this.Controls.Add(this.T_encoded);
            this.Controls.Add(this.Info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Info;
            this.Name = "Bacon";
            this.Text = "Bacon";
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_decoded;
        private System.Windows.Forms.TextBox T_encoded;
        private System.Windows.Forms.Button Code;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.Button Mask;
        private System.Windows.Forms.Button Demask;
        private System.Windows.Forms.TextBox T_Mask;
        private System.Windows.Forms.ToolStripMenuItem Info_prog;
        private System.Windows.Forms.MenuStrip Info;
        private System.Windows.Forms.TextBox Alphavit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem шифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Default_text;

    }
}

