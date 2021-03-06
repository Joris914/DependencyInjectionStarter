﻿using DependencyInjectionStarter.Library;
using Ninject;

namespace DependencyInjectionStarter
{
    class BandLocatorNinject
    {
        private StandardKernel _kernel;

        public BandLocatorNinject()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<RockBand>().ToSelf().InSingletonScope();
            _kernel.Bind<IInstrument>().To<Guitar>();
            _kernel.Bind<IInstrument>().To<Vocal>();
            _kernel.Bind<IInstrument>().To<BassGuitar>();
            _kernel.Bind<IInstrument>().To<Drums>();
        }

        public RockBand DefaultRockband
        { 
            get { return _kernel.Get<RockBand>(); }
        } 
    }
}
