# Desafio Radix - Gateway Pagamento

Implementação de um gateway especializado em e-commerce.

Até o momento foi implementado a integração com as seguintes adquirentes:
 - Stone (http://gateway.stone.com.br/docs/bem-vindo)
 - Cielo (https://developercielo.github.io/manual/cielo-ecommerce)
 
 
Nosso gateway tem um serviço especifico para analise antifraude, podendo ser habilitado ou não.



## Como usar:
- Você precisará do Visual Studio 2017 e do .NET Core SDK.
- O SDK e as ferramentas mais recentes podem ser baixados em https://dot.net/core.

Você também pode executar no Visual Studio Code, em Windows, Linux ou MacOS.

Use o seguinte comando para clonar e baixar o projeto: git clone https://github.com/lucianowlp/desafio-radix.git
Após baixar o projeto você poderá abrir-lo com VS 2017 ou o VS Code.
Para executar o projeto direto pelo seu terminal, navegue até a pasta onde baixou e execute os seguintes commandos:




## Tecnologias implementadas:

- ASP.NET Core 2.0 (with .NET Core)
 - ASP.NET WebApi Core
- .NET Core Native DI
- AutoMapper
- Swagger UI
- XUnit

## Arquitetura:

- Arquitetura completa com preocupações de separação de responsabilidade, código SOLID e Clean
- Domain Driven Design
- Repository and Generic Repository

## Serviços

- Historico de transações

merchantkey = 7FA24257-587D-4709-9179-6E81B004E9C4

{host}/api/TransactionHistory/{merchantkey}

=====================

- Manuteção dos lojistas

{host}/api/Lojista

  JSON de exemplo:
```
{
	"Name": "TESTE - Com antifraud habilitado",
	"LastName": "TESTE",
	"Password": "TESTE",
	"Email": "TESTE2@gmail.com",
	"MerchantKey": "7FA24257-587D-4709-9179-6E81B004E9C4"
}
```
- Realizar transações com cartão de credito

{host}/api/sales


 Headers: "Content-Type" = "application/json"
 
           "merchantkey" = F2A1F485-CFD4-49F5-8862-0EBC438AE923(Lojista sem antifraude habilitado)
	   
        ou "merchantkey" = 7FA24257-587D-4709-9179-6E81B004E9C4(Lojista com antifraude habilitado)


JSON de exemplo:           
```   
{
   "MerchantOrderId": "2014111703",
   "Payment":{
     "Operation":1,
     "Amount":15700,
     "Installments":1,
     "Descriptor":"123456789ABCD",
     "CreditCard":{
         "CreditCardNumber":"4551870000000183",
         "PrintedName":"Teste Holder",
         "ExpMonth":"12",
         "ExpYear": "2021",
         "SecurityCode":"123"
     }
    },
    "AntiFraud": {
    	"AnalysisLocation": "BRA",
    	"Orders": [
     		{
     			"ShippingData": {
     				"Address": {
     					"Country": "BRA"
     				}
     			}
     		}
     	]
     }
}
```
Documentação da API
=============
https://radixgateway.azurewebsites.net/swagger/



