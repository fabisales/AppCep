﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginaXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}

        // armazena sequencia de navegação
        private void MudarParaPagina2(object sender, EventArgs args)
        {          
            Navigation.PushAsync(new Pagina2());
        }

        private void ChamarModal (object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }

    }
}