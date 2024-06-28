# Sistema de Atualização Cadastral da PROAUTO

Este projeto foi desenvolvido como parte do processo de implementação de uma aplicação para atualização cadastral de associados da PROAUTO. A aplicação permite que os associados atualizem seus endereços, autenticando-se através do CPF e placa do veículo.

## Funcionalidades Implementadas

- **Autenticação**: Os associados podem se autenticar utilizando o CPF e a placa do veículo.
- **Visualização de Dados**: Após autenticados, os associados podem visualizar todos os seus dados cadastrais, incluindo Nome, CPF, Placa, Endereço e Telefone.
- **Atualização de Endereço**: A funcionalidade principal permite que os associados atualizem apenas o campo de endereço.
- **RESTful Services**: A aplicação utiliza amplamente serviços RESTful para comunicação entre cliente e servidor.

## Tecnologias Utilizadas

- **Linguagem**: C# com o framework .NET MVC.
- **Banco de Dados**: SQL Server com o uso do Microsoft.EntityFrameworkCore para acesso aos dados.
- **Design e Ferramentas**: Utilização de JSON para configurações e SQLServer.Server para gestão do banco de dados.

## Instruções para Execução

1. **Pré-requisitos**:
   - Visual Studio 2022 ou superior.
   - SQL Server Management Studio.
   - .NET SDK.

2. **Configuração do Banco de Dados**:
   - Configure a conexão com o banco de dados SQL Server no arquivo `appsettings.json`.
   - Execute as migrações para criar o banco de dados e as tabelas necessárias.

3. **Executando a Aplicação**:
   - Abra o projeto no Visual Studio.
   - Compile e execute a aplicação.

4. **Utilização**:
   - Acesse a aplicação através do navegador.
   - Use o CPF `12345678900` e a placa `ABC1234` para autenticar-se como associado de teste.
   - Você será redirecionado para a página inicial onde poderá visualizar e atualizar o endereço.
   - Para testar com novos associados, utilize o botão fornecido na interface para criar novos registros.
