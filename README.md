# Brincando com git e github

## Novo Repositório
### ...or create a new repository on the command line
echo "# temporario" >> README.md
- git init
- git add README.md
- git commit -m "first commit"
- git branch -M master
- git remote add origin https://github.com/user/nomerepo.git
- git push -u origin master
### …or push an existing repository from the command line
- git remote add origin https://github.com/user/nomerepo.git
- git branch -M master
- git push -u origin master

ATENÇÃO: origin = nome_do_repositório * * * pode-se aplicar outra nomenclatura.
### …or import code from another repository
- git clone ...


## Entendendo Branch
-  <b><i> git branch </i></b>: exibe as branch 
-  <b><i> git branch -a</i></b>: exibe tanto branchs locais quanto do repositório remoto
-  <b><i>git branch nome_da_branch </i></b>: cria a branch com nome especificado.
-  <b><i>git checkout nome_da_branch </i></b>: muda de branch
-  <b><i>git checkout -b nome_da_branch </i></b>: cria a branch e a coloca em plano de trabalho 

* A branch é criada com base no último commit da branch em plano de trabalho(ou seja, a branch criada é a última cópia salva da branch que estou). Entretanto é possivel criar uma branch com base em um commit especifico [<b><i>git checkout -b NOME hash </i></b>].

-  <b><i>git branch -d nome_da_branch </i></b>: deleta a branch
-  <b><i>git push -d nome_do_repositorio [*origin*] nome_da_branch </i></b>: deleta a branch do repositório remoto 

-  <b><i>git merge nome_da_branch </i></b>: fusão da branch 'nome_da_branch' com a branch em plano de trabalho. 

- - <b><i> git push --set-upstream origin nome_da_branch </i></b>: ATENÇÃO: comando necessário quando se tem uma branch local e quer empurrá-la para o repositório remoto. Isso acontece quando a branch é recém-criada, localmente, e portanto ainda não foi configurado seu repositório de destino.

## Entendo Repositório Remoto

-  <b><i> git clone https://... </i></b>: clona o repositório remoto
-  <b><i> git remote </i></b>: exibe os repositórios
-  <b><i> git remote -v </i></b>: exibe (fetch: de onde baixa) e (push: para onde empurra) dos repositórios rastreados
-  <b><i> git pull nome_do_repo </i></b>: puxa as alterações do repositório remoto
-  <b><i> git push nome_do_repo nome_da_branch </i></b>: empurra as alterações da branch para o repositório remoto
- - <b><i> git push --set-upstream origin nome_da_branch </i></b>: ATENÇÃO: comando necessário quando se tem uma branch local e quer empurrá-la para o repositório remoto. Isso acontece quando a branch é recém-criada, localmente, e portanto ainda não foi configurado seu repositório de destino.


## Configurando Credenciais com segurança

-   <b><i> git config --global credencial.helper 'cache --timeout=3600' </i></b>: configura as credenciais do usuário por um prazo especifico (em segundos).

## Fork Flow

`[ A fork is a copy of a repository. 
Forking a repository allows you to freely experiment with changes without affecting the original project.]`


> Fazer o Fork de um repositório permite que você experimente fazer alterações sem afetar o projeto original, pois o fork é uma cópia de um repositório open source, (podemos trabalhar livremente sobre essa cópia).

Podemos fazer uma referência para o projeto oficial no nosso ambiente de desenvolvimento, basta: 

- <b><i> [git remote add 'name' https://repositórioOficial ]  </i></b>: : aqui é possivel somente fazer o pull, não é possível enviar nossas modificações diretamente [push]. 

É possível fazer um pull request através da nossa fork (ou seja, nosso clone modificado).


- <b><i> [git remote -v ] </i></b> : exibe fetch e push dos repositórios rastreados  



<b><i> </i></b>:
<b><i> </i></b>:
<b><i> </i></b>: