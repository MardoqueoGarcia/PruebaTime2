using PruebaTime.ViewModel.MasterViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTime.Infraestructure
{
    public class InstanceLocator
    {
        #region Properties

        public SingletonViewModel Singleton
        {
            get;
            set;
        }
        #endregion

        #region Constructor

        public InstanceLocator()
        {
            this.Singleton = new SingletonViewModel();
        }
        #endregion
    }
}
