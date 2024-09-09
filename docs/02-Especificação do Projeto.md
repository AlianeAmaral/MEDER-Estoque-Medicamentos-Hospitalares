# Especificações do Projeto

## Personas

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t2-pmv-ads-2024-2-e2-mederfarma/blob/main/docs/img/1-persona-repositora.png"/>
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t2-pmv-ads-2024-2-e2-mederfarma/blob/main/docs/img/2-persona-farmaceutico.png"/>
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t2-pmv-ads-2024-2-e2-mederfarma/blob/main/docs/img/3-persona-medica.png"/>
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t2-pmv-ads-2024-2-e2-mederfarma/blob/main/docs/img/4-persona-enfermeiro.png"/>

## Histórias de Usuários

Com base na análise das personas, foram identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Letícia (Repositora)  | Preciso conseguir gerar relatórios com antecedência e com filtros, de medicamentos que estão próximos de acabar (menos de 10 unidades), próximos do vencimento (menos de 15 dias) ou com estoque zerado.  | Para conseguir realizar pedidos com antecedência e garantir que não ocorra de não terem medicamentos disponíveis para os pacientes. |
|Eduardo (Farmacêutico) | Preciso conseguir atualizar a quantidade dos produtos que estão sendo retirados pelos médicos e enfermeiros, tanto quanto a quantidade de entradas quando o repositor chega com novos medicamentos. | Para que eu mantenha o sistema sempre atualizado com dados reais das quantidades e informações corretas dos medicamentos que possuímos no momento. |
|Rosana (Médica) | Preciso conseguir consultar se existem disponíveis em estoque os remédios que desejo prescrever. | Para que não corra o risco de ser passado um remédio que não está disponível no estoque no momento, que pode gerar atraso e retrabalho no atendimento dos pacientes. |
|Carlos (Enfermeiro) | Preciso conseguir consultar medicamentos disponíveis ou consultar outras informações dos medicamentos se necessário. | Para poder ter em mãos as informações dos medicamentos que estão sendo aplicados e auxiliar o médico nas consultas se preciso, a fim de otimizar os atendimentos. |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir realizar login. | ALTA | 
|RF-002| O sistema deve permitir realizar logoff. | MÉDIA|
|RF-003| O sistema deve permitir realizar um cadastro de usuário. | ALTA |
|RF-004| O sistema deve possibilitar troca de senha de forma individual.  | MÉDIA |
|RF-005| O sistema deve permitir que o usuário possa atualizar entrada ou saída de produtos no estoque. | ALTA |
|RF-006| O sistema deve permitir edições de informações sobre os medicamentos no estoque (nome, tipo, lote, validade). | ALTA |
|RF-007| O sistema deve ter uma função de busca para localizar medicamentos por nome, exibindo seus dados e quantidade em estoque. | ALTA |
|RF-008| O sistema deve gerar relatório dos remédios em baixa quantidade no estoque (abaixo de 10 unidades). | ALTA |
|RF-009| O sistema deve gerar relatório dos remédios próximos ao vencimento (menos de 15 dias). | ALTA |
|RF-010| O sistema deve gerar relatório dos remédios com estoque zerado, que já estiveram no sistema. | BAIXA |
|RF-011| O sistema deve possuir dois tipos de acesso, sendo: Somente Leitura (Repositores, Médicos e Enfermeiros) e Leitura e Edição (Farmacêuticos, somente). | ALTA |

### Requisitos Não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ter uma interface intuitiva e amigável para facilitar o uso. | MÉDIA | 
|RNF-002| O sistema deve possuir um código de manutenção que não deixe a aplicação inativo por um longo período. | MÉDIA | 
|RNF-003| A aplicação deve processar requisições do usuário em no máximo 5s. | BAIXA | 
|RNF-003| A aplicação deve possuir tipos de acessos diferentes para garantir a integridade das informações.| ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrições                                          |
|--|-------------------------------------------------------|
|01| O projeto final deverá ser entregue até o final do semestre. |
|02| O código deve ser desenvolvido em linguagem de programação C#. |
|03| O projeto será realizado em 4 sprints (4 etapas), sendo entregue até o dia 08/12/2024, final da 5ª etapa. |

## Diagrama de Casos de Uso

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t2-pmv-ads-2024-2-e2-mederfarma/blob/main/docs/img/1-diagrama-atores.png"/>
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t2-pmv-ads-2024-2-e2-mederfarma/blob/main/docs/img/1-diagrama-casos-de-uso.png"/>
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t2-pmv-ads-2024-2-e2-mederfarma/blob/main/docs/img/2-diagrama-final.png"/>
