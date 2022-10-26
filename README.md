# SisIg - Sistemas Para Igrejas

Aplicativo desktop para auxiliar igrejas pequenas no seu controle financeiro e secretaria.
Iniciei este projeto em 2016 para atender a demanda de minha congregação. E mesmo sozinho, resolvi desenvolver do zero este sistema que seria capaz de funcionar sem SGBD e sem internet (uma vez que aqui no interior a conexão era escassa) na máquina Windows com compatibilidade em tablets Windows. Agora, em outubro de 2022 <b>(depois de assistir uma aula no bootcamp OrangeTech da DIO.me)</b> resolvi resgatar o projeto para disponibilizar para devs da minha cidade poderem estudar em um projeto que foi utilizado e ainda tem uma congregação da cidade utilizando.

Ainda estou no processo de Engenharia reversa da base de dados, uma vez que construí usando SQLite Studio, mas não encontrei o arquivo database. Algumas funções podem não estar disponíveis quando você executar, mas estou trabalhando rapidamente para liberar tudo em tempo hábil e só depois começarei a atualizar as interações nos forms e tratar o visual não muito ergonômico que adotei na época kkk.

Sinta-se livre para contribuir, eu estou mantendo o projeto na íntegra (incluindo dlls, objs e a pasta do debug para você abrir o .exe direto e testar as funcionalidade sem o VS) e estou à disposição para aprender com vocês aqui!

- Entradas e Saídas
- Lista de Membros
- Relatórios automatizados
- Visitantes
- Aniversariantes
- Cargos
- EBD (em breve)

## Membros

- Cadastro completo
- Admissões: cadastre as formas como um membro é arrolado (batismo, profissão de fé, etc)
- Histórico: cadastre as situações do membro ao longo do tempo
- Situações (em comunhão, disciplina, etc.)
- Lista de Aniversariantes
- Impressão de ficha individual,
- Impressão de ficha para cadastro

## Financeiro

- Entradas e Saídas
- Cadastro de categorias para relatórios
- Lançamento em lote (lance todas as entradas/saídas de uma vez)
- Saldo atualizado automaticamente
- Entradas vinculadas aos membros cadastrados

### Relatórios financeiros

- Lista de lançamentos
- Agrupados de forma mensal (todos os dízimos, todas as ofertas, etc)
- Agrupados de forma anual
- Agrupados mensal e anual de forma gráfica
- Balancete
- Balancete gráfico
- Lista de membros por entrada (todos os dizimistas do mês por exemplo)
- Lista de entradas por membro (tudo que o membro contribuiu no mês)
- Livro Caixa mensal

## Visitantes

- Cadastro completo
- Visitas recebidas/realizadas
- Aniversariantes (nascimento e casamento)

## Cargos

- Lista de Cargos
- Atribuir um cargo à um membro e definir data de início/fim


## Aniversariantes

- Lista de Aniversariantes da semana/mês/ano
- Tanto de membros quanto de aniversariantes



# Observações
Certifique-se de instalar a extensão para manipular os relatórios de forma gráfica seguindo os passos abaixo:

1. Abra o Menu "Extensões" --> Gerenciar extensões
2. Procure por "rdlc"
3. Instale a extensão conforme o print abaixo:

![print da instalação](https://github.com/jhonsreis/ControleFinanceiroIgreja/blob/main/extras/captura_rdlc.png?raw=true)
