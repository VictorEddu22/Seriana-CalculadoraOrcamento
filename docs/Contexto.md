# Seriana - Sistema de Orçamento#

## Introdução
A Seriana utiliza atualmente uma planilha de Excel para realizar cálculos de orçamento, aproveitamento de materiais e definição de processos produtivos.

A planilha recebe informações como formato e tamanho do produto, quantidade solicitada, material, gramatura, tamanho e custo da chapa, tipo de impressão, corte, sangria e tolerâncias. Com esses dados, ela calcula o aproveitamento, a quantidade de chapas, os tempos de produção, os custos e compara diferentes rotas, como Esko, Mapcut, Corte e Vinco e Guilhotina.

Apesar de ser funcional, a planilha possui aproximadamente 300 mil fórmulas e diversas abas técnicas, tornando sua manutenção complexa e aumentando o risco de alterações incorretas, duplicidade de versões e perda de informações.

Por isso, será desenvolvido um sistema web que preserve as regras e os cálculos da planilha, mas ofereça uma utilização mais simples, segura e organizada. O sistema terá interface visual, banco de dados, controle de usuários, histórico de orçamentos, validações automáticas e armazenamento centralizado das informações.

A planilha será utilizada como principal fonte das regras de negócio. A migração deverá acontecer por etapas, com testes que garantam que os resultados do sistema sejam equivalentes aos resultados corretos da planilha.

## Problema

Atualmente, os cálculos de orçamento, aproveitamento de materiais, custos e processos produtivos são realizados em uma planilha de Excel com diversas abas e aproximadamente 300 mil fórmulas.

Essa complexidade dificulta a manutenção, o entendimento das regras e o uso simultâneo por várias pessoas. Também existe risco de alterações acidentais nas fórmulas, duplicidade de arquivos, perda do histórico e utilização de versões desatualizadas.

## Justificativa

A criação de um sistema web permitirá centralizar as informações e transformar os cálculos da planilha em regras de negócio mais seguras, organizadas e fáceis de manter.

O sistema também permitirá controlar usuários, armazenar orçamentos, consultar históricos, atualizar custos e equipamentos, comparar rotas produtivas e registrar as decisões tomadas.

Dessa forma, a Seriana poderá reduzir erros manuais, melhorar a confiabilidade dos orçamentos e facilitar o acesso às informações.

## Objetivo

Desenvolver um sistema web completo para realizar orçamentos e cálculos de aproveitamento de materiais com base nas regras existentes na planilha da Seriana.

O sistema deverá:

* Calcular o aproveitamento de materiais;
* Calcular a quantidade necessária de chapas ou bobinas;
* Comparar diferentes rotas produtivas;
* Calcular custos e tempos de produção;
* Indicar a rota mais adequada;
* Armazenar orçamentos no banco de dados;
* Manter histórico de alterações e resultados;
* Controlar o acesso dos usuários;
* Apresentar resultados de forma simples e segura.

## Público-alvo

O sistema será utilizado principalmente por:

* Orçamentistas;
* Equipe de PCP;
* Engenharia e Processos;
* Equipe Comercial;
* Gestores de produção;
* Administradores responsáveis pelos custos, máquinas e regras do sistema.

