﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLogic.Configuration;
using Models;

namespace EcoSim.Models
{
    public class SimulationTemplate
    {
        public Simulation Simulation { get; set; }
        public NetworkConfiguration NetworkConfiguration { get; set; }
        public List<DecisionChance> DecisionChances { get; set; }
    }
}