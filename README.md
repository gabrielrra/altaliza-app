# Altaliza Web App

Um aplicativo para alugar carros, de forma ágil.

Projeto desenvolvido como desafio para um processo seletivo

# Instalação

Certifique-se de que tem `Docker`, `Node` e `.Net5` instalados na sua máquina.

## Web

Abra um terminal dentro da pasta **web** e instale as dependências com yarn ou npm: `yarn install` ou `npm i`.

Depois é só rodar, dentro da mesma pasta, `yarn dev` ou `npm dev`.

## API

Primeiramente, na raiz do projeto rode `docker-compose up -d` para rodar o banco de dados de forma autônoma.

Após o banco de dados inicializado, entre na pasta `api/Altaliza.Api` e abra um terminal. Execute o comando `dotnet restore` e depois `dotnet run`

# Conclusão

Após todos os passos executados, entre no navegador e acesse http://localhost:3000, que é onde está hospedada a aplicação web.

