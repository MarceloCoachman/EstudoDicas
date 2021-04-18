git --version = Verifique se o Git foi instalado corretamente. Deverá retornar a versão instalada

git init (iniciar repositorio no git)

git add (mover arquivos e dar inicio ao versionamento)

git commit (criar commites)

git add * = Comando para adicionar as alterações feitas em todos os arquivos do projeto

git commit -m "" = Comando para fazer um commit do seu projeto (colocar uma mensagem dentro das strings "")

git status = Mostra as informações sobre a situação atual do seu repositório

git log = Verifica todas as alterações feitas no projeto que está sendo monitorado

git config --global --unset user.email (comando para limpar o seu email no perfil)

git config --global --unset user.nickname (comando para limpar o seu user no perfil)

git config --list (comando para ver a lista de configurações)

git config --global user.email "seu email"(comando para adicionar o seu email no perfil)

git config --global user.nickname "seu nome"(comando para adicionar o seu user no perfil)

git remote add origin (link do seu repositório GitHub) = comando para adicionar seu repositório GitHub a sua maquina local | origin = apelido do seu link repositório

git remote -v = Comando para listar seus repositórios cadastrados

git pull origin master = Comando para puxar um conteúdo do seu repositório remoto

git push origin master = Comando para empurrar seu repositório local para o remoto

git clone (link)

git branch <criabranch> = Só cria a branch, sem entrar nelaorigin mastergit --

git checkout -b <criando a brach e mudando pra ela> = Cria a branch e já entra nela

git checkout <nome da branche> = Muda de branch

git checkout -t <nome da branche> = Baixa a branch remota e muda pra ela

git merge <nome da branche> = Junta as branchs

git fetch = Baixa todas as branchs remotas