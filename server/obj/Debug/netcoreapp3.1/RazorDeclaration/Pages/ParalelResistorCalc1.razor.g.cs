#pragma checksum "D:\WebProjects\AllInOneHelp\server\Pages\ParalelResistorCalc1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea15648af943e444b4f577df9568fda506954253"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AllInOneHelp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\WebProjects\AllInOneHelp\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\WebProjects\AllInOneHelp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\WebProjects\AllInOneHelp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\WebProjects\AllInOneHelp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\WebProjects\AllInOneHelp\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\WebProjects\AllInOneHelp\server\_Imports.razor"
using AllInOneHelp.Shared;

#line default
#line hidden
#line 4 "D:\WebProjects\AllInOneHelp\server\Pages\ParalelResistorCalc1.razor"
using Radzen;

#line default
#line hidden
#line 5 "D:\WebProjects\AllInOneHelp\server\Pages\ParalelResistorCalc1.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 6 "D:\WebProjects\AllInOneHelp\server\Pages\ParalelResistorCalc1.razor"
using System.Text.Json;

#line default
#line hidden
#line 7 "D:\WebProjects\AllInOneHelp\server\Pages\ParalelResistorCalc1.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/paralel-resistor-calc")]
    public partial class ParalelResistorCalc1 : AllInOneHelp.Pages.ParalelResistorCalcComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 41 "D:\WebProjects\AllInOneHelp\server\Pages\ParalelResistorCalc1.razor"
  public class ResistorRow
    {
        public int Id { get; set; }
        public string Nominal { get; set; }
        public int? quoteId { get; set; }
    }
    public class Quote
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    List<Quote> Quotes = new List<Quote>()
    {
        new Quote{Id=1, Name="Ом"},
        new Quote{Id=2, Name="кОм"},
        new Quote{Id=3, Name="МОм"},
    };
    List<ResistorRow> ResistorRows = new List<ResistorRow>()
    {
        new ResistorRow{Id=1, Nominal="0", quoteId=1},
        new ResistorRow{Id=2, Nominal="0", quoteId=1}
    };

    private double RezSum = 0;
    private double RezSumOm = 0;
    private bool ActivDeleteButton = true;
    private int ResultQuote = 1;

    private void Calculate()
    {
        RezSumOm = 0;
        foreach (var item in ResistorRows)
        {

            switch (item.quoteId)
            {
                case 1:
                    RezSumOm += 1 / double.Parse(item.Nominal);
                    break;
                case 2:
                    RezSumOm += 1 / double.Parse(item.Nominal) / 1000;
                    break;
                case 3:
                    RezSumOm += 1 / double.Parse(item.Nominal) / 1000 / 1000;
                    break;

                default:
                    break;
            }
        }
        RezSumOm = 1 / RezSumOm;
        CorrectRezSum();
    }
    private void AddResistor()
    {
        ResistorRows.Add(new ResistorRow() { Id = ResistorRows.Count + 1, Nominal = "0", quoteId = 1 });
        if (ResistorRows.Count > 2)
        {
            ActivDeleteButton = false;
        }
    }
    private void DeleteResistor()
    {
        if (ResistorRows.Count > 2)
        {
            ResistorRows.Remove(ResistorRows.Last());
        }
        if (ResistorRows.Count <= 2)
        {
            ActivDeleteButton = true;
        }

    }
    private void CorrectRezSum()
    {
        switch (ResultQuote)
        {
            case 1:
                RezSum = RezSumOm;
                break;
            case 2:
                RezSum = RezSumOm / 1000;
                break;
            case 3:
                RezSum = RezSumOm / 1000 / 1000;
                break;

            default:
                break;
        }
    } 

#line default
#line hidden
    }
}
#pragma warning restore 1591
