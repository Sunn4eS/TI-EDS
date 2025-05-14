namespace EDS_RSA;

public partial class MainForm : Form
{
    private long r;
    private long eds;
    private long ee;
    private int p;
    private int q;
    private long d;
    private long euler;
    private long hash;
    byte[] OpenedFileBytes { get; set; }
    
    
    public MainForm()
    {
        InitializeComponent();
    }

    private void getParamsButton_Click(object sender, EventArgs e)
    {
        qTextBox.Text = string.Join("", qTextBox.Text.Where(char.IsDigit));
        pTextBox.Text = string.Join("", pTextBox.Text.Where(char.IsDigit));
        dTextBox.Text = string.Join("", dTextBox.Text.Where(char.IsDigit));
        if (pTextBox.Text.Length == 0)
        {
            MessageBox.Show("Длина вашего P должна быть отлична от нуля!", "Внимание");
            return;
        }
        
        if (qTextBox.Text.Length == 0)
        {
            MessageBox.Show("Длина вашего Q должна быть отлична от нуля!", "Внимание");
            return;
        }
        p = int.Parse(pTextBox.Text);
        if (!MathTools.IsPrime(p))
        {
            MessageBox.Show("Ваше число P не является простым!", "Внимание");
            return;
        }
        q = int.Parse(qTextBox.Text);
        if (!MathTools.IsPrime(q))
        {
            MessageBox.Show("Ваше число Q не является простым!", "Внимание");
            return;
        }
        r = q * p;
        if (r < 256)
        {
            MessageBox.Show("Ваше произведение P и Q должно быть не меньше 256!", "Внимание");
            return;
        }
        rTextBox.Text = r.ToString();
        euler = MathTools.EulerPhi(p, q);
        eulerTextBox.Text = euler.ToString();
        
        if (dTextBox.Text.Length == 0)
        {
            MessageBox.Show("Длина вашей закрытой константы D должна быть отлична от нуля!", "Внимание");
            return;
        }

        d = long.Parse(dTextBox.Text);
        if (d < 1 || d >= euler)
        {
            MessageBox.Show("Ваша закрытая константа D меньше 1 или больше функции эйлера!", "Внимание");
            return;
        }
       // long gcd = RSA.FindGcd(BigIntegerD, BigIntegerFunctionR);
        if (MathTools.IsRelativelyPrime(d, euler))
        {
            MessageBox.Show("Ваша закрытая константа D не взаимно простая с функцией Эйлера!", "Внимание");
            return;
        } 
        ee = MathTools.ModInverse(euler, d);
        if (ee < 0)
        {
            ee += euler;
        }
        eTextBox.Text = ee.ToString();
        getEDSButton.Enabled = true;



    }

    private void getEDSButton_Click(object sender, EventArgs e)
    {
        hash = EDS.HashFunction(OpenedFileBytes, r);
        hashTextBox.Text = hash.ToString();
        eds = MathTools.FastPowMul(hash, d, 1, r);
        edsTextBox.Text = eds.ToString();
    }
}