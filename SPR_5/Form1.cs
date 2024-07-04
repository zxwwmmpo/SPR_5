using Microsoft.Extensions.Logging;

namespace SPR_5;

public partial class Form1 : Form
{
    private readonly ILogger logger;

    public Form1(ILogger<Form1> _logger)
    {
        InitializeComponent();
        logger = _logger;
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
        try
        {
            double res = 0;
            double x = double.Parse(textBoxInput.Text);
            logger.LogInformation("start");
            for (double i = 1; i <= 10; i++)
            {
                res -= ((Math.Pow(x, 2 * i)) / (i));

                logger.LogInformation("s = " + $"{i} {res}");
            }
            textBoxOutput.Text = res.ToString();

            double res2 = (Math.Log(1 - (Math.Pow(x, 2))));
            textBoxOutputY.Text = (Math.Log(1-(Math.Pow(x, 2)))).ToString();

            logger.LogInformation("y = " + $"{res2}");
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
        }
    }
}