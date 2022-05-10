using st_dependencies;

namespace ScoreTrackerApp
{
    public partial class score_tracker : Form
    {
        private Dictionary<string, int> Scores { get; set; }
        public Dictionary<string, string> ScoreBaseText { get; set; }

        public score_tracker()
        {
            InitializeComponent();
            InitializeScoreBaseText();
            AssignToolTips();
        }

        private void InitializeScoreBaseText()
        {
            ScoreBaseText = new Dictionary<string, string>();
            ScoreBaseText.Add("Chris", this.chris_score.Text);
            ScoreBaseText.Add("Daria", this.daria_score.Text);
        }

        private void InitializeScores(int chris, int daria)
        {
            Scores = new Dictionary<string, int>();
            Scores.Add("Chris", chris);
            Scores.Add("Daria", daria);
        }

        private void AssignToolTips()
        {
            this.tt.SetToolTip(this.chris_score, "Shows Chris's Score");
            this.tt.SetToolTip(this.daria_score, "Shows Daria's Score");
            this.tt.SetToolTip(this.chris_panel, "Actions for Chris");
            this.tt.SetToolTip(this.daria_panel, "Actions for Daria");
            this.tt.SetToolTip(this.chris_textbox, "Enter an amount for Chris's actions");
            this.tt.SetToolTip(this.daria_textbox, "Enter an amount for Daria's actions");
            this.tt.SetToolTip(this.chris_add, "Add the amount in the textbox to Chris's total score");
            this.tt.SetToolTip(this.daria_add, "Add the amount in the textbox to Daria's total score");
            this.tt.SetToolTip(this.chris_remove, "Remove the amount in the textbox from Chris's total score");
            this.tt.SetToolTip(this.daria_remove, "Remove the amount in the textbox from Daria's total score");
            this.tt.SetToolTip(this.chris_check, "Update Chris's Score");
            this.tt.SetToolTip(this.daria_check, "Update Daria's Score");
        }

        public async Task<int> ShowScores()
        {
            Tuple<bool, string> result;
            int score;

            result = await API.Get("chris");
            score = int.Parse(result.Item2.Substring(result.Item2.IndexOf(':') + 2));
            this.chris_score.Text = ScoreBaseText["Chris"] + score.ToString();

            result = await API.Get("daria");
            score = int.Parse(result.Item2.Substring(result.Item2.IndexOf(':') + 2));
            this.daria_score.Text = ScoreBaseText["Daria"] + score.ToString();

            return 0;
        }

        private async void chris_add_Click(object sender, EventArgs e)
        {
            DialogResult user_choice = DialogResult.Cancel;
            do
            {
                int amount;
                if (this.chris_textbox.Text == "") amount = 1;
                else
                    amount = int.Parse(this.chris_textbox.Text);

                if (amount == 0) return; // will have no effect

                Tuple<bool, string> result = await API.Put("chris", amount);

                if (!result.Item1)
                {
                    user_choice = MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    // update score display
                    int newAmount = Scores["Chris"] + amount;
                    this.chris_score.Text = ScoreBaseText["Chris"] + newAmount;
                    Scores["Chris"] = newAmount;
                }

            } while (user_choice == DialogResult.Retry);

            this.chris_textbox.Text = "";
            if (this.chris_textbox.Text != "")
                this.ActiveControl = this.chris_textbox;
        }

        private async void daria_add_Click(object sender, EventArgs e)
        {
            DialogResult user_choice = DialogResult.Cancel;
            do
            {
                int amount;
                if (this.daria_textbox.Text == "") amount = 1;
                else
                    amount = int.Parse(this.daria_textbox.Text);

                if (amount == 0) return; // will have no effect

                Tuple<bool, string> result = await API.Put("daria", amount);

                if (!result.Item1)
                {
                    user_choice = MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    // update score display
                    int newAmount = Scores["Daria"] + amount;
                    this.daria_score.Text = ScoreBaseText["Daria"] + newAmount;
                    Scores["Daria"] = newAmount;
                }

            } while (user_choice == DialogResult.Retry);

            this.daria_textbox.Text = "";
            if (this.daria_textbox.Text != "")
                this.ActiveControl = this.daria_textbox;
        }

        private async void chris_remove_Click(object sender, EventArgs e)
        {
            DialogResult user_choice = DialogResult.Cancel;
            do
            {
                int amount;
                if (this.chris_textbox.Text == "") amount = 1;
                else
                    amount = int.Parse(this.chris_textbox.Text) - (int.Parse(this.chris_textbox.Text) * 2);

                if (amount == 0) return; // will have no effect

                Tuple<bool, string> result = await API.Put("chris", amount);

                if (!result.Item1)
                {
                    user_choice = MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    // update score display
                    int newAmount = Scores["Chris"] + amount;
                    this.chris_score.Text = ScoreBaseText["Chris"] + newAmount;
                    Scores["Chris"] = newAmount;
                }
            } while (user_choice == DialogResult.Retry);

            this.chris_textbox.Text = "";
            if (this.chris_textbox.Text != "")
                this.ActiveControl = this.chris_textbox;

        }

        private async void daria_remove_Click(object sender, EventArgs e)
        {
            DialogResult user_choice = DialogResult.Cancel;
            do
            {
                int amount;
                if (this.daria_textbox.Text == "") amount = 1;
                else
                    amount = int.Parse(this.daria_textbox.Text) - (int.Parse(this.daria_textbox.Text) * 2);

                if (amount == 0) return; // will have no effect

                Tuple<bool, string> result = await API.Put("daria", amount);

                if (!result.Item1)
                {
                    user_choice = MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    // update score display
                    int newAmount = Scores["Daria"] + amount;
                    this.daria_score.Text = ScoreBaseText["Daria"] + newAmount;
                    Scores["Daria"] = newAmount;
                }

            } while (user_choice == DialogResult.Retry);

            this.daria_textbox.Text = "";
            if (this.daria_textbox.Text != "")
                this.ActiveControl = this.daria_textbox;
        }

        private void chris_check_Click(object sender, EventArgs e)
        {
            ShowScores();
        }

        private void daria_check_Click(object sender, EventArgs e)
        {
            ShowScores();
        }

        private bool nonNumberEntered = false;
        private void chris_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            // If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void daria_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            // If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private async void score_tracker_Load(object sender, EventArgs e)
        {
            // update the score labels and Scores Dictionary before the program starts
            await ShowScores();
            int chris_score = int.Parse(this.chris_score.Text.Substring(this.chris_score.Text.IndexOf(':') + 2));
            int daria_score = int.Parse(this.daria_score.Text.Substring(this.daria_score.Text.IndexOf(':') + 2));
            InitializeScores(chris_score, daria_score);

            // clear wait screen
            this.loading_cover.Hide();
        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control
        private void chris_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control
        private void daria_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void score_tracker_Click(object sender, EventArgs e)
        {
            this.ActiveControl = this.chris_score;
        }
    }
}