﻿using ReinforcedConcreteFactoryBusinessLogic.BusinessLogic;
using ReinforcedConcreteFactoryBusinessLogic.Interfaces;
using ReinforcedConcreteFactoryFileImplement.Implements;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace ReinforcedConcreteFactoryView
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<IComponentLogic, ComponentLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProductLogic, ProductLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IClientLogic, ClientLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<MainLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderLogic, OrderLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IImplementerLogic, ImplementerLogic>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}