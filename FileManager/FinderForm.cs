using System.Text.RegularExpressions;

namespace FileManager
{
    public partial class FinderForm : Form
    {
        public FinderForm(UserSettings userSettings, string path)
        {
            
            InitializeComponent();
            pathTextBox.Text = path;
            Decor(userSettings);
        }
        private void Decor(UserSettings userSettings)
        {
            Font = userSettings.UserFont;
            BackColor = userSettings.UserColor;
        }
        List<string> finded = new List<string>();
        private void searchButton_Click(object sender, EventArgs e)
        {
            filesListBox.Items.Clear();
            finded.Clear();
            if (File.Exists(pathTextBox.Text))
            {
                string s = File.ReadAllText(pathTextBox.Text);
                Regex regexF = new Regex(regexTextBox.Text);
                MatchCollection temp = regexF.Matches(s);
                foreach (Match match in temp)
                {
                    finded.Add(match.Groups[0].Value);
                }
            }
            else
            {
                Recursive(pathTextBox.Text);
                void Recursive(string currentPath)
                {
                    Parallel.ForEach(Directory.GetDirectories(currentPath), s =>
                    {
                        Regex regexF = new Regex(regexTextBox.Text);
                        MatchCollection temp = regexF.Matches(new DirectoryInfo(s).Name);
                        if (temp.Count > 0) finded.Add(new DirectoryInfo(s).Name);
                        Recursive(s);
                    });
                    Parallel.ForEach(Directory.GetFiles(currentPath), s =>
                    {
                        Regex regexF = new Regex(regexTextBox.Text);
                        MatchCollection temp = regexF.Matches(new DirectoryInfo(s).Name);
                        if (temp.Count > 0) finded.Add(new DirectoryInfo(s).Name);

                    });
                }
            }
            string[] finded2 = new string[finded.Count];
            for (var i = 0; i < finded.Count; i++) { finded2[i] = finded[i]; }
            filesListBox.Items.AddRange(finded2);
        }
    }
}
