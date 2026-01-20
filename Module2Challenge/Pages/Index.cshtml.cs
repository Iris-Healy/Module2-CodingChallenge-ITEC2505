using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module2Challenge.Pages;
public class IndexModel : PageModel
{
    //Initialize public vars 
    [BindProperty] 
    public double milesDriven {get; set;}
    [BindProperty]
    public double gallonsUsed {get; set;}
    public double mPG {get; set;}
    public bool showResult {get; set;}
    public string? errorMessage {get; set;}

    //hide result on page init
    public void OnGet()
    {
        showResult = false;
    }
    public void OnPost()
    {
        //prevent div by zero error
        if (gallonsUsed == 0)
        {
            errorMessage ="Gallons used cannot be zero.";
            showResult = false;
        }
        else
        {
        // Calculate mPG
        mPG = milesDriven / gallonsUsed;
        showResult = true;
        }
    }
}
