using AppFlyout.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFlyout.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel 
    {
        private string itemId;
        private string nome;
        private string sipnose;
        private string ano;

        public string Id { get; set; }

        public string Nome
        {
            get => nome;
            set => SetProperty(ref nome, value);
        }

        public string Sinopse
        {
            get => sipnose;
            set => SetProperty(ref sipnose, value);
        }

        public string Ano
        {
            get => ano;
            set => SetProperty(ref ano, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Nome = item.Nome;
                Sinopse = item.Sinopse;
                Ano = item.Ano;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
