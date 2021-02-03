# Projeto Integração Api's

Este projeto foi desenvolvido com entuito de expor minhas habilidades com C# e .Net Core,
o mesmo tem objetivo alvo o desenvolvimento de duas Api's que devem se comunicar entre si, outros objetivos relacionados são expor meu nível de maturidade com o paradigma orientado a objetos, arquitetura de software, propriedades (Coesão, Acoplamento, Encapsulamento e Extensibilidade) e princípios (SOLID) de projetos.

## Arquitetura
  ambas as Api's seguem um padrão arquitetural em camadas, o qual permite ter Coesão, Baixo acoplamento e Extensibilidade, encapsulamento a nível de arquitetura.
  As camadas são: Controllers, Domain e Infrastructure, sendo que a camada superior acessa apenas a camada inferior mais próxima.

<pre>
Estrutura das Camadas:
  Controllers
  Domain
  Infrastructure

Formas de acesso:
  Controllers -> Domain
  Domain -> Infrastructure   
  Infrastructure -> com terceiros (BD,Api's e etc.)
</pre>
  
  
## Api1
 Descrição: Esta api possui um endpoint o qual retorna um json com valor que representa um taxa padrão

 ### Estrutura
  <pre>
    /
    Controllers/
                TaxaJuros.cs (Endpoint)               
    Domain/     
          Models/
                Taxa.cs (representação de uma taxa)
  </pre>

## Chamadas a Api1
  Get: https://localhost:5001/taxajuros

## Ap2
Descrição: Esta api possui dois endpoints, um que retorna o calculo de juros composto dado uma valor inicial e a quantidade de meses e retorna o montante calculado, e outro retonar o link do repositório no github onde se encontra este projeto.

 ### obs: a taxa utilizada para o calculo de juros composto vem da Ap1.

 ### Estrutura
  <pre>
    /
    Controllers/
                CalculaJuros.cs (Endpoint) 
                ShowMeTheCode.cs (Endpoint)
    Domain/     
          Models/
                Montante.cs (Classe modelo)
                Code.cs (Classe modelo)
          Utils/
                MathUtils.cs (Classe de Calculos matemáticos)
    Infrastructure/
                  ApiService/
                            Models/
                                  Ap1/
                                     Taxa.cs (Classe modelo)
                                  GitHub/
                                        Repo.cs (Classe modelo)
                            ApiService.cs (Classe genérica de acesso a Api's)
  </pre>

  ## Chamadas a Api2
  Get: https://localhost:5003/calculajuros?valorInicial={valor decimal}&meses={valor inteiro}

  Get: https://localhost:5003/showmethecode

  