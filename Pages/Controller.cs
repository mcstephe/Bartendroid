using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Device.Gpio;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
using Bartendroid.Data;
using Bartendroid.Models;

namespace Bartendroid.Controller;

public class Controller
{

    // 
    // Motor calibration 

    // Motor control

    // I2C Connection

    // Motor Control

    //Motor Properties
    // Calibration Settings: Each pump will have a different flow rate

    //private readonly Bartendroid.Data.Context _context;

    public Controller() 
    {
        //private readonly Bartendroid.Data.Context? _context;     
    }

    public IList<Pump> Pump { get;set; } = default!;

    public void Dispense(int _pump, double _quantity) 
    {
        // 
    }



}