using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4e7ca3b3_daf2_4aea_b8b7_5b31a2905c37
{
    class Program
    {
        static void Main(string[] args)
        {
ArticleModel articleTrouvé;
articleTrouvé = AddArticleCollection.SingleOrDefault(article => article.Id == txtIDProduit.Text);

if (articleTrouvé == null)
{
    AddArticleCollection.Add(new ArticleModel
    {
        ID = txtIDProduit.Text,
        Design = txtDesigProduit.Text,
        Qte = int.Parse(txt_qte_produit.Text),
        PrixVente = double.Parse(txtPUProduit.Text)
    });
}
else
{
    articleTrouvé.Qte++;
}
        }
    }
}
