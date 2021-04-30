*Realize o clone desse repositorio! (Diretorio na máquina de sua preferencia)

		* As instruções estão dentro de cada projeto. Verifique e implemente, após realizar os testes e responder as questões, faça um pull request para o repositorio inicial *
   
# Questões Teóricas

* Qual a diferença entre uma Struct e uma Class?
Struct normalmente é utilizado para operações simples, de acesso público, normalmente utilizado como VO (Value Objects)
Classe é utilizada para operações complexas, regras de negócios, etc, tendo acesso privado.

* Explique a grande diferença entre .NET e .NET CORE.
.Net Core é focado em aplicações Web, não oferece o mesmo suporte para aplicações desktop que o .NET oferece

* Quais as principais diferenças entre REST e GRPC?
REST é uma arquitetura de consumo e construção de microserviços, com estrutura de envio e recebimento de informações. Normalmente utiliza JSON ou XML.
GRPC é uma nova arquitetura proposta pelo Google, porém não possuo conhecimento da estrutura.

* Explique como funciona um gerenciamento de rotas de uma SPA.
Não possuo experiência específica com SPA, mas sei que utilizam AJAX, uma tecnologia que utilizo de forma recorrente no meu dia a dia.

* Falando sobre DevOps, comente o que conhece sobre.
Devops é uma boa prática de desenvolvimento que busca melhorar a qualidade, quantidade e agilidade das entregas, ao mesmo tempo que reduz problemas que impactam na usabilidade da ferramenta desenvolvida, sejam eles bugs, problemas no servidor, base de dados, etc. Para isso, são utilizados padrões de desenvolvimento, documentações padrões e ferramentas de controle para facilitar a identificação de problemas e correções.

* Explique sobre um método agile.
SCRUM é um dos métodos Agile mais conhecidos no mercado. É definido um SCRUM master, que fica responsável por controlar as atividades/histórias/projetos de uma equipe, realizando feedbacks constantes, normalmente diários, e sprints, que são pequenas entregas em um período definido, normalmente semanais.

* Comente sobre CI e CD e algumas ferramentas do dia a dia.
É uma parte do Devops, utilizados para manter as entregas rápidas e consistentes, com o mínimo de erros possíveis. Selenium é uma das ferramentas utilizadas para teste automatizado, porém minha experiência com essa ferramenta foi puramente para a criação de um RPA.

* Qual a diferença entre Docker e Containers.

* Qual a diferença entre Kubernetes e Openshift?
Openshift é um container virtualizado(cloud) baseado no Kubernetes

* Quais as vantagens e desvantagens sobre API e quais preocupaçõe devemos ter quando escolhemos essa abordagem?
A vantagem da API é a possibilidade de distribuição do serviço de forma mais prática e rápida. A preocupação com essa abordagem é a segurança da informação. Há diversas abordagens para solucionar esse problema, como tokens de autenticação.

* Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?
Pode-se utilizar tokens de identificação do solicitante ou verificação de informações do solicitante.

* Quando devemos utilizar um sistema de mensageria e quais as preocupações dessa abordagem?
Quando temos diversos sistemas que precisam trocar informações entre si. A única preocupação que tenho conhecimento sobre mensageria é a questão da disponibilidade do sistema. Caso esteja indisponível, as mensagens estão represadas, porém, serão processadas quando o serviço voltar

* Qual a diferença entre Mensagem e Eventos?
Mensagem é o conteúdo da informação do sistema de mensageria. Evento é a regra de negócio para o disparo da mensagem

* Cite 6 fatores do Twelve-Factor App e explique cada um deles.
Não possuo conhecimento nesse tema. 

* Quais são as principais camadas no desenvolvimento de um software?
Arquitetura MVC, Model, View e Control. Que são as camadas de Dados, Visualização e Negócio

* Diferencie Arquitetura SOA X Arquitetura microserviços.
SOA é arquitetura baseada em serviço, as funcionalidades da aplicação são expostas como WebService. Arquitetura de microserviços é parecido com SOA, mas são mais independentes e não necessariamente estão conectados entre si.

* Cite dois APIs Managements, dois API Gateways utilizados no mercado e os diferencie.
Postman e API ServiceNow.
Oracla API (Não conheço outro software)
API Management são softwares utilizados para gerenciar as chamadas de API, indicar performance, etc. Os de Gateway são como um proxy, onde todas as chamadas de API passam por ele.
* Desenvolva um diagrama técnico para um sistema de Supermercado. O seu desenho deverá trazer segurança, escalabilidade, monitoramento e integrações com terceiros.
