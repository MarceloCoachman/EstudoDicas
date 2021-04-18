<h3 align="center">
  <a href="https://git-scm.com/">Git</a> e <a href="https://github.com/">GitHub</a>: Controle e Compartilhe seu Código
</h3>



### Observações:

###### Objetos internos no Git

Blobs, Trees, Commits







| Comandos                                                 | Descrição                                                    |
| :------------------------------------------------------- | ------------------------------------------------------------ |
| git --version                                            | Verifique se o Git foi instalado corretamente e deverá retornar a versão instalada |
| git init                                                 | iniciar repositório no git                                   |
| git add                                                  | mover arquivos e dar inicio ao versionamento                 |
| git commit                                               | criar commit                                                 |
| git add *                                                | Comando para adicionar as alterações feitas em todos os arquivos do projeto |
| git commit -m ""                                         | Comando para fazer um commit do seu projeto (colocar uma mensagem dentro das strings "") |
| git status                                               | Mostra as informações sobre a situação atual do seu repositório |
| git log                                                  | Verifica todas as alterações feitas no projeto que está sendo monitorado |
| git config --global --unset user.email                   | comando para limpar o seu e-mail no perfil                   |
| git config --global --unset user.nickname                | comando para limpar o seu user no perfil                     |
| git config --list                                        | comando para ver a lista de configurações                    |
| git config --global user.email "seu email"               | comando para adicionar o seu e-mail no perfil                |
| git config --global user.nickname "seu nome"             | comando para adicionar o seu user no perfil                  |
| git remote add origin (+ link do seu repositório GitHub) | comando para adicionar seu repositório GitHub a sua maquina local. origin = apelido do seu link do repositório |
| git remote -v                                            | Comando para listar seus repositórios cadastrados            |
| git pull origin master                                   | Comando para puxar um conteúdo do seu repositório remoto     |
| git push origin master                                   | Comando para empurrar seu repositório local para o remoto    |
| git clone (link do repositório GitHub)                   | Copia o repositório remoto para onde esta sendo executado o git clone |
| git branch  (cria branch)                                | Só cria a branch, sem entrar nela origin mastergit --        |
| git checkout -b (criando a branch e mudando pra ela)     | Cria a branch e já entra nela                                |
| git checkout (nome da branch)                            | Muda de branch                                               |
| git checkout -t <nome da branche>                        | Baixa a branch remota e muda pra ela                         |
| git merge <nome da branche>                              | Junta as branchs                                             |
| git fetch                                                | Baixa todas as branchs remotas                               |
|                                                          |                                                              |

 

SHA1
Comando que gera o SHA1 = openssl sha1 (nome do arquivo.txt)
	Chave gerada = SHA1(nome do arquivo.txt) = 476ad3f360ced25383c25d13eae57f59e30cecb9



Para que o git não monitore arquivos, é necessário criar um arquivo do tipo 

.gitignore = Dentro do arquivo, você deve colocar o nome dos arquivos que deseja ignorar