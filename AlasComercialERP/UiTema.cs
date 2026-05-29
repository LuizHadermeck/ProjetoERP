using System.Drawing;
using System.Windows.Forms;

namespace AlasComercialERP
{
    public static class UiTema
    {
        public static readonly Color Background = Color.FromArgb(245, 247, 250);
        public static readonly Color Surface = Color.White;
        public static readonly Color Text = Color.FromArgb(31, 34, 46);
        public static readonly Color MutedText = Color.FromArgb(91, 98, 112);
        public static readonly Color Menu = Color.FromArgb(31, 34, 46);
        public static readonly Color MenuTop = Color.FromArgb(24, 27, 38);
        public static readonly Color MenuHover = Color.FromArgb(43, 47, 64);
        public static readonly Color GridLine = Color.FromArgb(226, 232, 240);

        public static Color Primary
        {
            get
            {
                return CorTema.PrimaryColor == default(Color)
                    ? Color.FromArgb(0, 150, 136)
                    : CorTema.PrimaryColor;
            }
        }

        public static Color Secondary
        {
            get
            {
                return CorTema.SecondaryColor == default(Color)
                    ? Color.FromArgb(39, 39, 58)
                    : CorTema.SecondaryColor;
            }
        }

        public static Font TitleFont(float size)
        {
            return new Font("Segoe UI Semibold", size, FontStyle.Bold, GraphicsUnit.Point, 0);
        }

        public static Font BodyFont(float size)
        {
            return new Font("Segoe UI", size, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        public static void ApplyHeader(Panel header, Label title, Label subtitle)
        {
            if (header != null)
                header.BackColor = Primary;

            if (title != null)
            {
                title.Font = TitleFont(title.Font.Size < 12F ? 15F : title.Font.Size);
                title.ForeColor = Color.White;
            }

            if (subtitle != null)
            {
                subtitle.Font = BodyFont(subtitle.Font.Size < 9F ? 10F : subtitle.Font.Size);
                subtitle.ForeColor = Color.WhiteSmoke;
            }
        }

        public static void ApplySurface(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                if (control == null)
                    continue;

                control.BackColor = Surface;
                control.Font = BodyFont(control.Font == null ? 10F : control.Font.Size);
            }
        }

        public static void ApplyFormControls(Control parent)
        {
            if (parent == null)
                return;

            foreach (Control control in parent.Controls)
            {
                if (control is Label label)
                {
                    label.ForeColor = Secondary;
                    if (label.Font.Size <= 10F)
                        label.Font = TitleFont(9.5F);
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Text;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = BodyFont(10F);
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.BackColor = Color.White;
                    comboBox.ForeColor = Text;
                    comboBox.FlatStyle = FlatStyle.Flat;
                    comboBox.Font = BodyFont(10F);
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.BackColor = Color.White;
                    numericUpDown.ForeColor = Text;
                    numericUpDown.BorderStyle = BorderStyle.FixedSingle;
                    numericUpDown.Font = BodyFont(10F);
                }

                if (control.HasChildren)
                    ApplyFormControls(control);
            }
        }

        public static void ApplyButtons(Control container)
        {
            if (container == null)
                return;

            foreach (Control control in container.Controls)
            {
                if (control is Button button)
                    ApplyButton(button);

                if (control.HasChildren)
                    ApplyButtons(control);
            }
        }

        public static void ApplyButton(Button button)
        {
            if (button == null)
                return;

            button.BackColor = Primary;
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Secondary;
            button.FlatAppearance.MouseOverBackColor = ControlPaint.Light(Primary);
            button.FlatAppearance.MouseDownBackColor = Secondary;
            button.Font = TitleFont(9.5F);
        }

        public static void ApplyGrid(DataGridView grid)
        {
            if (grid == null)
                return;

            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = GridLine;
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = 32;
            grid.ColumnHeadersHeight = 36;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Secondary;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = TitleFont(9F);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Secondary;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.Font = BodyFont(9.5F);
            grid.DefaultCellStyle.BackColor = Surface;
            grid.DefaultCellStyle.ForeColor = Text;
            grid.DefaultCellStyle.SelectionBackColor = ControlPaint.Light(Primary);
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Text;
        }

        public static void ApplySectionTitle(Label label)
        {
            if (label == null)
                return;

            label.ForeColor = Text;
            label.Font = TitleFont(label.Font.Size < 11F ? 12F : label.Font.Size);
        }

        public static void ApplySummaryCards(Control container)
        {
            if (container == null)
                return;

            foreach (Control control in container.Controls)
            {
                if (control is Panel card)
                {
                    card.BackColor = Surface;
                    card.Padding = card.Padding == Padding.Empty ? new Padding(14) : card.Padding;

                    foreach (Control child in card.Controls)
                    {
                        if (child is Label label)
                            label.ForeColor = label.Font.Size >= 18F ? Primary : MutedText;
                    }
                }
            }
        }
    }
}
