using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Pages.Products
{
    public partial class ProductsPage
    {
        private List<string> listOfProducts = new();
        private int quantity;
        private int numberOfProductsInCart = 0;
        private bool showCartBadge = false;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(50);

            for (int i = 0; i < 10; i++)
            {
                listOfProducts.Add("teste");
            }
        }

        private void AddToCart()
        {
            Snackbar.Add("Adicionado ao carrinho!", Severity.Success);
            numberOfProductsInCart++;
            showCartBadge = true;
        }
    }
}
