
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication;
namespace Classes;
public class Converter
{
    public double currency;
    public Boolean currtype; // false > bgtoeur | true > eurtobg
    public double convcurr = Converter.Exchange();
    public Converter () { }
    public Converter (double curruncy, Boolean currtype) { this.currency = currency; this.currtype = currtype; }
    public double Exchange ()
    {
        double coeff = 0.51;
        if(currtype == false) { return coeff * currency; } else { return currency / coeff; }
    }
}