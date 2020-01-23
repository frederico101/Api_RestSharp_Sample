using System;
using System.Collections.Generic;

namespace ApiPNB.entities
{
            public class Content
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string tipo { get; set; }
            public string cpf { get; set; }
            public string cnpj { get; set; }
            public DateTime dataNascimento { get; set; }
            public string sexo { get; set; }
            public string numeroIdentidade { get; set; }
            public string orgaoExpedidorIdentidade { get; set; }
            public string unidadeFederativaIdentidade { get; set; }
            public object dataEmissaoIdentidade { get; set; }
            public bool flagDeficienteVisual { get; set; }
        }

        public class JsonCpf
        {
            public int number { get; set; }
            public int size { get; set; }
            public int totalPages { get; set; }
            public int numberOfElements { get; set; }
            public int totalElements { get; set; }
            public bool firstPage { get; set; }
            public bool hasPreviousPage { get; set; }
            public bool hasNextPage { get; set; }
            public bool hasContent { get; set; }
            public bool first { get; set; }
            public bool last { get; set; }
            public int nextPage { get; set; }
            public int previousPage { get; set; }
            public List<Content> content { get; set; }
        }
}