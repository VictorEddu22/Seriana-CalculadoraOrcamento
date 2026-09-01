# Seriana Calculadora de Orçamento #

## Introdução
A Seriana utiliza atualmente uma planilha de Excel para realizar cálculos de orçamento, aproveitamento de materiais e definição de processos produtivos.

A planilha recebe informações como formato e tamanho do produto, quantidade solicitada, material, gramatura, tamanho e custo da chapa, tipo de impressão, corte, sangria e tolerâncias. Com esses dados, ela calcula o aproveitamento, a quantidade de chapas, os tempos de produção, os custos e compara diferentes rotas, como Esko, Mapcut, Corte e Vinco e Guilhotina.

Apesar de ser funcional, a planilha possui aproximadamente 300 mil fórmulas e diversas abas técnicas, tornando sua manutenção complexa e aumentando o risco de alterações incorretas, duplicidade de versões e perda de informações.

Por isso, será desenvolvido um sistema web que preserve as regras e os cálculos da planilha, mas ofereça uma utilização mais simples, segura e organizada. O sistema terá interface visual, banco de dados, controle de usuários, histórico de orçamentos, validações automáticas e armazenamento centralizado das informações.

A planilha será utilizada como principal fonte das regras de negócio. A migração deverá acontecer por etapas, com testes que garantam que os resultados do sistema sejam equivalentes aos resultados corretos da planilha.
