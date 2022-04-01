using Contactos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contactos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactoMantenimiento : ContentPage
    {
        public ContactoMantenimiento(ContactoViewModel vm)
        {
            //Contacto nuevo
            InitializeComponent();
            vm.Contacto = new Models.Contacto() { Id = Guid.NewGuid().ToString()};
            vm.Contacto.Telefonos = new System.Collections.ObjectModel.ObservableCollection<Models.Telefono>();
            BindingContext = vm;
            Title = "Nuevo Contacto";
        }

        public ContactoMantenimiento(Models.Contacto contacto, ContactoViewModel vm)
        {
            //Contacto existente
            InitializeComponent();
            vm.Contacto = new Models.Contacto();
            vm.Contacto = contacto;
            BindingContext = vm;
            Title = "Editar Contacto";
        }
    }
}