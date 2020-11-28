﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.TagHelpers
{
    public class MensagemTagHelper : TagHelper
    {
        public string Sucesso { get; set; }
        public string Erro { get; set; }


        // <div class="alert alert-success">Sucesso</div>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Valida se o Sucesso não está vazio ou nulo
            if (!string.IsNullOrEmpty(Sucesso))
            {
                //A tag que será criada
                output.TagName = "div";
                //Definir alguns atributos da tag html (name, class, id...)
                output.Attributes.SetAttribute("class","alert alert-success mx-auto");
                //Definir o conteúdo da tag
                output.Content.SetContent(Sucesso);
            }

            if (!string.IsNullOrEmpty(Erro))
            {
            //A tag que será criada
            output.TagName = "div";
            //Definir alguns atributos da tag html (name, class, id...)
            output.Attributes.SetAttribute("class","alert alert-danger mx-auto");
            //Definir o conteúdo da tag
            output.Content.SetContent(Erro);
            }
        }
    }
}