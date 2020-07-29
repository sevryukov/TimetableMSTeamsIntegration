# Contribution Guidelines

Данное руководство формализует правила работы над проектом с использованием сервиса контроля версий GitHub и является частью рекомендованных сообществом GH действий по повышению качества кодовой базы (репозитория).

## Процесс работы

Общий шаблон работы представляет из себя следующий итеративный процесс:

Определяем задачи итерации.
1.1. Для каждой задачи создаем Issue и назначаем ответственного(-ых).
1.2. Если требуется, то до первых результатов, проводим предварительное обсуждение в комментариях к Issue.

Каждая задача решается в отдельной ветке (название ветки issues/<issue_number> - это делается для упрощения процесса навигации между ветками в браузере и упрощения названий веток).
2.1. В процессе решения задачи, каждый коммит начинается с префикса в виде названия ветки (также для навигации в браузере).
2.2. Если какой-либо коммит является промежуточным и/или исправлением предыдущего не забудьте произвести rebase/squash.
2.3. Мы стремимся к тому, чтобы коммиты отражали лог внесенных изменений и не имели исправлений (если исправление, не является требуемым изменением).

По достижению некоторых положительных промежуточных результатов создается Pull Request и помечается как WIP (Work In Progress, в случае GH нужно пометить его как Draft при создании).
3.1. Дальнейшее обсуждение должно проводиться уже в комментариях к PR и по большей части касаться предложенной реализации.

По завершению работы над задачей делаем запрос на Code Review и ждем решения ревьюеров.