# Testes de Software com .NET: Exemplos de Utilização

O autoestudo fornece diversos exemplos de implementação de testes em aplicações baseadas no .NET. Ele inclui repositórios demonstrando o uso de xUnit, NUnit, MSTest, Moq, NSubstitute, Fluent Assertions e SpecFlow. A automação de testes com GitHub Actions e Azure DevOps também é abordada juntamente com o SpecFlow.

## Testes de Unidade

Os testes de unidade são essenciais para validar o comportamento de métodos individuais dentro do código. Nesta seção, vou mostrar três exemplos de testes de unidade utilizando os frameworks xUnit, NUnit e MSTest. Todos os exemplos envolvem a conversão de temperaturas de Fahrenheit para Celsius.

### Conceitos Aprendidos

- **Testes Parametrizados**: Utilização de atributos como `[Theory]` e `[InlineData]` no xUnit, `[TestCase]` no NUnit, e `[DataTestMethod]` e `[DataRow]` no MSTest para criar testes reutilizáveis com diferentes conjuntos de dados.
- **Assert Statements**: Verificação dos resultados esperados dos testes usando várias funções de assertividade, como `Assert.Equal` e `Assert.AreEqual`.

### Tecnologias Utilizadas

- **.NET**: Plataforma de desenvolvimento para construir aplicações.
- **xUnit**: Framework de testes de unidade popular e amplamente utilizado no ecossistema .NET.
- **NUnit**: Outro framework de testes de unidade, conhecido pela sua flexibilidade.
- **MSTest**: Framework de testes de unidade desenvolvido pela Microsoft, integrado ao Visual Studio.

### Exemplo 1: .NET + Unit Testing + xUnit + Conversão de Temperaturas

Utilizando xUnit, empregamos os atributos `[Theory]` e `[InlineData]` para criar testes parametrizados:

```csharp
using System;
using Xunit;

namespace Temperatura.Testes
{
    public class TestesConversorTemperatura
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(47, 8.33)]
        [InlineData(86, 30)]
        [InlineData(90.5, 32.5)]
        [InlineData(120.18, 48.99)]
        [InlineData(212, 100)]
        public void TestarConversaoTemperatura(double fahrenheit, double celsius)
        {
            double valorCalculado = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            Assert.Equal(celsius, valorCalculado);
        }
    }
}
```

### Exemplo 2: .NET + Unit Testing + NUnit + Conversão de Temperaturas

Com NUnit, utilizamos o atributo `[TestCase]` para definir os dados de teste:

```csharp
using NUnit.Framework;

namespace Temperatura.Testes
{
    public class TestesConversorTemperatura
    {
        [TestCase(32, 0)]
        [TestCase(47, 8.33)]
        [TestCase(86, 30)]
        [TestCase(90.5, 32.5)]
        [TestCase(120.18, 48.99)]
        [TestCase(212, 100)]
        public void TesteConversaoTemperatura(double tempFahrenheit, double tempCelsius)
        {
            double valorCalculado = ConversorTemperatura.FahrenheitParaCelsius(tempFahrenheit);
            Assert.AreEqual(tempCelsius, valorCalculado);
        }
    }
}
```

### Exemplo 3: .NET + Unit Testing + MSTest + Conversão de Temperaturas

Com MSTest, utilizamos os atributos `[DataTestMethod]` e `[DataRow]` para definir os testes parametrizados:

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Temperatura.Testes
{
    [TestClass]
    public class TestesConversorTemperatura
    {
        [DataRow(32, 0)]
        [DataRow(47, 8.33)]
        [DataRow(86, 30)]
        [DataRow(90.5, 32.5)]
        [DataRow(120.18, 48.99)]
        [DataRow(212, 100)]
        [DataTestMethod]
        public void TesteConversaoTemperatura(double tempFahrenheit, double tempCelsius)
        {
            double valorCalculado = ConversorTemperatura.FahrenheitParaCelsius(tempFahrenheit);
            Assert.AreEqual(tempCelsius, valorCalculado);
        }
    }
}
```

## Mock Objects

Mocks são fundamentais para testar componentes de software de forma isolada, simulando comportamentos e interações de dependências externas. A seguir, vou mostrar dois exemplos utilizando os frameworks Moq e NSubstitute.

### Conceitos Aprendidos

- **Criação de Mocks**: Uso de frameworks como Moq e NSubstitute para criar objetos simulados que replicam o comportamento de dependências reais.
- **Configuração de Comportamentos**: Definição dos retornos esperados e lançamento de exceções para diferentes entradas de métodos simulados.
- **Verificação de Interações**: Validação de que métodos específicos foram chamados com os parâmetros corretos durante o teste.

### Tecnologias Utilizadas

- **.NET**: Plataforma de desenvolvimento para construir aplicações modernas.
- **Moq**: Biblioteca popular para criação de Mocks em testes de unidade no .NET.
- **NSubstitute**: Alternativa ao Moq, conhecida pela sua simplicidade e sintaxe fluente.
- **Fluent Assertions**: Biblioteca para escrita de asserções legíveis e expressivas.

#### Exemplo 1: .NET + xUnit + Moq + Fluent Assertions

Com Moq e Fluent Assertions, podemos criar Mocks de forma detalhada e verificar resultados com mensagens customizadas:

```csharp
using System;
using System.Collections.Generic;
using Xunit;
using Moq;
using FluentAssertions;

namespace ConsultaCredito.Testes
{
    public class TestesAnaliseCredito
    {
        private readonly Mock<IServicoConsultaCredito> mock;

        public TestesAnaliseCredito()
        {
            mock = new Mock<IServicoConsultaCredito>(MockBehavior.Strict);

            mock.Setup(s => s.ConsultarPendenciasPorCPF("123A")).Returns(() => null);
            mock.Setup(s => s.ConsultarPendenciasPorCPF("76217486300")).Throws(new Exception("Testando erro de comunicação"));
            mock.Setup(s => s.ConsultarPendenciasPorCPF("60487583752")).Returns(() => new List<Pendencia>());

            var pendencia = new Pendencia
            {
                CPF = "82226651209",
                NomePessoa = "Cliente Teste",
                NomeReclamante = "Empresas ACME",
                DescricaoPendencia = "Parcela não paga",
                VlPendencia = 900.50
            };
            var pendencias = new List<Pendencia> { pendencia };
            mock.Setup(s => s.ConsultarPendenciasPorCPF("82226651209")).Returns(() => pendencias);
        }

        private StatusConsultaCredito ObterStatusAnaliseCredito(string cpf)
        {
            var analise = new AnaliseCredito(mock.Object);
            return analise.ConsultarSituacaoCPF(cpf);
        }

        [Fact]
        public void TestarCPFInvalidoMoq()
        {
            var status = ObterStatusAnaliseCredito("123A");
            status.Should().Be(StatusConsultaCredito.ParametroEnvioInvalido, "Resultado incorreto para um CPF inválido");
        }

        [Fact]
        public void TestarErroComunicacaoMoq()
        {
            var status = ObterStatusAnaliseCredito("76217486300");
            status.Should().Be(StatusConsultaCredito.ErroComunicacao, "Resultado incorreto para um erro de comunicação");
        }

        [Fact]
        public void TestarCPFSemPendenciasMoq()
        {
            var status = ObterStatusAnaliseCredito("60487583752");
            status.Should().Be(StatusConsultaCredito.SemPendencias, "Resultado incorreto para um CPF sem pendências");
        }

        [Fact]
        public void TestarCPFInadimplenteMoq()
        {
            var status = ObterStatusAnaliseCredito("82226651209");
            status.Should().Be(StatusConsultaCredito.Inadimplente, "Resultado incorreto para um CPF inadimplente");
        }
    }
}
```

### Exemplo 2: .NET + xUnit + NSubstitute + Fluent Assertions

Com NSubstitute, a criação de Mocks é mais direta e menos verbosa:

```csharp
using System;
using FluentAssertions;
using NSubstitute;
using System.Collections.Generic;
using Xunit;

namespace ConsultaCredito.Testes
{
    public class TestesAnaliseCredito
    {
        private readonly IServicoConsultaCredito _mock;

        public TestesAnaliseCredito()
        {
            _mock = Substitute.For<IServicoConsultaCredito>();

            _mock.ConsultarPendenciasPorCPF("123A").Returns((List<Pendencia>)null);
            _mock.ConsultarPendenciasPorCPF("76217486300").Returns(s => { throw new Exception("Erro de comunicação..."); });
            _mock.ConsultarPendenciasPorCPF("60487583752").Returns(new List<Pendencia>());

            var pendencia = new Pendencia
            {
                CPF = "82226651209",
                NomePessoa = "Cliente Teste",
                NomeReclamante = "Empresas ACME",
                DescricaoPendencia = "Parcela não paga",
                VlPendencia = 900.50
            };
            var pendencias = new List<Pendencia> { pendencia };
            _mock.ConsultarPendenciasPorCPF("82226651209").Returns(pendencias);
        }

        private StatusConsultaCredito ObterStatusAnaliseCredito(string cpf)
        {
            var analise = new AnaliseCredito(_mock);
            return analise.ConsultarSituacaoCPF(cpf);
        }

        [Fact]
        public void TestarCPFInvalidoNSubstitute()
        {
            var status = ObterStatusAnaliseCredito("123A");
            status.Should().Be(StatusConsultaCredito.ParametroEnvioInvalido, "Resultado incorreto para um CPF inválido");
        }

        [Fact]
        public void TestarErroComunicacaoNSubstitute()
        {
            var status = ObterStatusAnaliseCredito("76217486300");
            status.Should().Be(StatusConsultaCredito.ErroComunicacao, "Resultado incorreto para um erro de comunicação");
        }

        [Fact]
        public void TestarCPFSemPendenciasNSubstitute()
        {
            var status = ObterStatusAnaliseCredito("60487583752");
            status.Should().Be(StatusConsultaCredito.SemPendencias, "Resultado incorreto para um CPF sem pendências");
        }

        [Fact]
        public void TestarCPFInadimplenteNSubstitute()
        {
            var status = ObterStatusAnaliseCredito("82226651209");
            status.Should().Be(StatusConsultaCredito.Inadimplente, "Resultado incorreto para um CPF inadimplente");
        }
    }
}
```

## SpecFlow

O SpecFlow é uma ferramenta de BDD (Behavior Driven Development) que permite escrever testes de aceitação legíveis por humanos. A seguir, um exemplo de SpecFlow para a simulação de juros compostos.

### Conceitos Aprendidos

- **BDD (Behavior Driven Development)**: Desenvolvimento guiado pelo comportamento, onde os requisitos são especificados em forma de exemplos e cenários de uso.
- **Gherkin Language**: Linguagem usada para escrever cenários de testes BDD de forma estruturada e legível.
- **Step Definitions**: Mapeamento de passos em Gherkin para código C# que executa as ações e validações definidas nos cenários.

### Tecnologias Utilizadas

- **.NET**: Plataforma de desenvolvimento para construir aplicações.
- **SpecFlow**: Ferramenta de BDD para .NET, que permite a escrita de testes de aceitação em uma linguagem natural.
- **xUnit**: Framework de testes de unidade, usado como backend de execução dos testes SpecFlow.
- **Swagger**: Ferramenta para documentação e teste de APIs RESTful.
- **Docker**: Plataforma de contêineres usada para automatizar a implantação de aplicações em ambientes consistentes.


### Exemplo: ASP.NET Core 5 + REST API + xUnit + SpecFlow + Swagger + Dockerfile + Juros Compostos

No repositório, definimos uma user story para calcular juros compostos:

```gherkin
Funcionalidade: Cálculo de Juros Compostos

Cenário: SimulacaoJurosCompostos01
    Dado que o valor o valor do empréstimo é de R$ 10.000,00
    E que este empréstimo será por 12 meses
    E que a taxa de juros é de 2,00% ao mês
    Quando eu solicitar o cálculo do valor total a ser pago ao final do período
    Então o resultado será 12.682,42

Cenário: SimulacaoJurosCompostos02
    Dado que o valor o valor do empréstimo é de R$ 11.937,28
    E que este empréstimo será por 24 meses
    E que a taxa de juros é de 4,00% ao mês
    Quando eu solicitar o cálculo do valor total a ser pago ao final do período
    Então o resultado será 30.598,88

Cenário: SimulacaoJurosCompostos03
    Dado que o valor o valor do empréstimo é de R$ 15.000,00
    E que este empréstimo será por 36 meses
    E que a taxa de juros é de 6,00% ao mês
    Quando eu solicitar o cálculo do valor total a ser pago ao final do período
    Então o resultado será 122.208,78

Cenário: SimulacaoJurosCompostos04
    Dado que o valor o valor do empréstimo é de R$ 10.000,00
    E que este empréstimo será por 2 meses
    E que a taxa de juros é de 2,00% ao mês
    Quando eu solicitar o cálculo do valor total a ser pago ao final do período
    Então o resultado será 10.404,00

Cenário: SimulacaoJurosCompostos05
    Dado que o valor o valor do empréstimo é de R$ 20.000,00
    E que este empréstimo será por 36 meses
    E que a taxa de juros é de 6,00% ao mês
    Quando eu solicitar o cálculo do valor total a ser pago ao final do período
    Então o resultado será 162.945,04

Cenário: SimulacaoJurosCompostos06
    Dado que o valor o valor do empréstimo é de R$ 25.000,00
    E que este empréstimo será por 48 meses
    E que a taxa de juros é de 6,00% ao mês
    Quando eu solicitar o cálculo do valor total a ser pago ao final do período
    Então o resultado será 409.846,79

Cenário: SimulacaoJurosCompostos07
    Dado que o valor o valor do empréstimo é de R$ 30.000,00
    E que este empréstimo será por 3 meses
    E que a taxa de juros é de 3,00% ao mês
    Quando eu solicitar o cálculo do valor total a ser pago ao final do período
    Então o resultado será 32.781,81
```

A seguir, a classe Step Definition que mapeia as sentenças da user story para o código em C#:

```csharp
using Xunit;
using TechTalk.SpecFlow;

namespace APIFinancas.Especificacoes
{
    [Binding]
    public class CalculoJurosCompostosStepDefinition
    {
        private double _valorEmprestimo;
        private int _numMeses;
        private double _percTaxa;
        private double _valorCalculado;

        [Given(@"que o valor o valor do empréstimo é de R\$ (.*)")]
        public void PreencherValorEmprestimo(double valorEmprestimo)
        {
            _valorEmprestimo = valorEmprestimo;
        }

        [Given(@"que este empréstimo será por (.*) meses")]
        public void PreencherNumeroMeses(int numMeses)
        {
            _numMeses = numMeses;
        }

        [Given(@"que a taxa de juros é de (.*)% ao mês")]
        public void PreencherPercentualTaxa(double percTaxa)
        {
            _percTaxa = percTaxa;
        }

        [When(@"eu solicitar o cálculo do valor total a ser pago ao final do período")]
        public void ProcessarCalculoJurosCompostos()
        {
            _valorCalculado = CalculoFinanceiro.CalcularValorComJurosCompostos(_valorEmprestimo, _numMeses, _percTaxa);
        }

        [Then(@"o resultado será (.*)")]
        public void ValidarResultado(double valorFinalEmprestimo)
        {
            Assert.Equal(valorFinalEmprestimo, _valorCalculado);
        }
    }
}
```

## Conclusão

O autoestudo ilustra como diferentes frameworks e abordagens podem ser utilizados para implementar testes em aplicações .NET 5. A prática de escrever testes de unidade, utilizar Mock Objects e adotar BDD com SpecFlow é crucial para garantir a qualidade e a robustez do software. Além disso, a automação de testes com ferramentas como GitHub Actions e Azure DevOps contribui para a eficiência e a confiabilidade no processo de desenvolvimento.