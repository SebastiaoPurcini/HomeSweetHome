# HomeSweetHome Project

Para esse projeto foi desenvolvida uma aplicação onde o usuário poderá consultar as Famílias cadastradas, na qual será apresentada uma lista em ordem de maior pontuação que é gerada 
seguindo a regra de negócio apresentada. Em caso de empate é avaliado a Renda e Quantidade de Dependentes. Nessa lista é destacada a família que está apta a ganhar a casa popular do governo. 
Também é possível a partir dessa, consultar os Membros que fazem parte da família.

O projeto foi desenvolvido utilizando-se 3 camadas de respnsabilidades: Core, Infra e UI

- Core: Foram criadas aqui as Entidades referente a ideia do projeto, as Interfaces, Extensões e um folder "Business" que contem a regra de Calculo para a pontuação. 
Nessa também foram criadas factories(Services\Factories), para gerar uma simulação de dados, uma vez que não estão sendo consumidos;

- Infra: Nessa camada que seria responsavel pelo acesso aos dados, foram criadas Implementations que consomem das factories, para simular os dados;

- UI: Distribuidos aqui os aquivos relacionados à interface de usuário, contendo os Controllers, ViewModels (separei aqui utilizando o conceito de ViewModel, deixando os modelos dentro de Core) e Views;

Após a execução do projeto, pode-se acessar a lista de famílias através do botão "Famílias Candidatas" na página principal.
