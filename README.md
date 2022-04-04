# Brincando com git e github

## Entendendo Branch
-  <b><i> git branch </i></b>: exibe as branch 
-  <b><i> git branch -a</i></b>: exibe tanto branchs locais quanto do repositório remoto
-  <b><i>git branch nome_da_branch </i></b>: cria a branch com nome especificado.
-  <b><i>git checkout nome_da_branch </i></b>: muda de branch
-  <b><i>git checkout -b nome_da_branch </i></b>: cria a branch e a coloca em plano de trabalho 

* A branch é criada com base no último commit da branch em plano de trabalho(ou seja, a branch criada é a última cópia salva da branch que estou). Entretanto é possivel criar uma branch com base em um commit especifico [<b><i>git checkout -b NOME hash </i></b>].

-  <b><i>git branch -d nome_da_branch </i></b>: deleta a branch
-  <b><i>git merge nome_da_branch </i></b>: fusão da branch 'nome_da_branch' com a branch em plano de trabalho. 

-  <b><i> git push --set-upstream origin nome_da_branch </i></b>: ATENÇÃO: comando necessário quando se tem uma branch local e quer empurrá-la para o repositório remoto. Isso acontece quando a branch é recém-criada, localmente, e portanto ainda não foi configurado seu repositório de destino.

## Entendo Repositório Remoto

-  <b><i> git clone https://... </i></b>: clona o repositório remoto
-  <b><i> git remote </i></b>: exibe os repositórios
-  <b><i> git remote -v </i></b>: exibe o (fetch: de onde baixa) e (push: para onde empurra)
-  <b><i> git pull nome_do_repo </i></b>: puxa as alterações do repositório remoto
-  <b><i> git push nome_do_repo nome_da_branch </i></b>: empurra as alterações da branch para o repositório remoto
-  <b><i> git push --set-upstream origin nome_da_branch </i></b>: ATENÇÃO: comando necessário quando se tem uma branch local e quer empurrá-la para o repositório remoto. Isso acontece quando a branch é recém-criada, localmente, e portanto ainda não foi configurado seu repositório de destino.


## Configurando Credenciais com segurança

-   <b><i> git config --global credencial.helper 'cache --timeout=3600' </i></b>: configura as credenciais do usuário por um prazo especifico (em segundos).

