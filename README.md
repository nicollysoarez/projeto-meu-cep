# projeto-meu-cep
Aplicação console em C# que realiza consulta de CEP consumindo a API pública do ViaCEP.
<img width="2000" height="2000" alt="White" src="https://github.com/user-attachments/assets/831ce1a0-b2cd-4f9b-b4f6-4e4908f0b4b1" />



# 📍 Consulta de CEP em C# (.NET)

> Aplicação de console leve e prática para consulta de endereços brasileiros em tempo real utilizando a API pública do ViaCEP.

---

## 📌 Sobre o Projeto

O **meu-cep** é uma ferramenta desenvolvida para demonstrar a integração de projetos C# com APIs REST externas. Ele recebe o CEP digitado pelo usuário, realiza a validação do formato, trata a requisição HTTP de forma assíncrona e exibe as informações de logradouro, bairro, cidade e UF diretamente no terminal.

---

## 🚀 Tecnologias Utilizadas

* **C# / .NET**
* **System.Net.Http.Json** (para consumo de API REST e desserialização de JSON)
* **API ViaCEP** (serviço web gratuito de busca de CEP)

---

## ⚒️ Funcionalidades

- [x] Tratamento e limpeza da entrada do usuário (remove hífens e espaços acidentais).
- [x] Validação de formato (garante exatamente 8 dígitos).
- [x] Consumo assíncrono (`async/await`) da API do ViaCEP.
- [x] Mapeamento direto de JSON para `record` em C#.
- [x] Tratamento defensivo de erros (falhas de conexão e CEPs inexistentes).

---

## ⚙️ Como Executar o Projeto

### Pré-requisitos
* [.NET SDK 6.0](https://dotnet.microsoft.com/download) ou superior instalado.

### Passo a Passo

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/nicollysoarez/projeto-meu-cep.git](https://github.com/nicollysoarez/projeto-meu-cep.git)
