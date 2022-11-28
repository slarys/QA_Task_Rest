# QA_Task_Rest


QA Задание – рестораны и их меню.
Вы молодой энтузиаст жаждущий изучить ресторанный бизнес, и стать акулой в этой сфере. Вы достаточно мудры чтобы изучить этот гурманский мир чудес и гастрономических фантазий, прежде чем стремглав открывать свой бизнес. Через путь полный боли и страданий, вы, превозмогая все мыслимые и немыслимые пределы, используя все возможности вашей сети информаторов (в которой по чистой случайности состоите только вы) вы начинаете собирать информацию о ваших конкурентах.
И все вроде бы хорошо, но вот беда! Вы понимаете, что вся собранная информация в разброс записана в ваш блокнот, и если дело пойдет так дальше, то вы рискуете в будущем не разобрать эту груду непонятных слов и стрелок. И, (о совпадение), вы начали собирать данные о рынке ресторанного бизнеса в момент вашего обучения в It-Academy на курсе по c# разработке, и вы понимаете, что у вас превосходная возможность отточить свои навыки и облегчить свою жизнь.
После нескольких часов кропотливой работы, к такому плану вы пришли:
⦁	Создание базовых классов.
⦁	Есть продукты, которые делятся на несколько подтипов: это овощи, фрукты, мясо, специи. У каждого продукта есть свое название, а также цена за 1 грамм. 
⦁	Есть также блюда, которые состоят из ингредиентов, названия и цены. Ингредиент содержит в себе само блюдо (именно объект класса блюда), и вес в граммах.
⦁	Этап создание заведения.
⦁	Есть рестораны каждый из которых производит свой список блюд.
Магазины имеют свое название, и имя шеф-повара. Надо разработать консольное приложение, с помощью которого можно посмотреть меню каждого.

Во время запуска программа должна отобразить на консоли название заведения и шеф повара. При выборе нужного заведения отобразить меню блюд. 
⦁	В меню должно отображаться наименование блюда, цена, ингредиенты и вес.
⦁	У каждого заведения есть свой процент обслуживания, но не больше 20%, так что помимо цены надо отобразить цену с обслуживанием.
⦁	Реализовать возможность отображения самого часто используемого типа продукта во всех блюдах ресторана (в количественном плане, это по граммам). 
⦁	Бонус: можно сделать сортировку всех блюд в соотношении цена/себестоимость.
⦁	При просмотре меню, требуется отсортировать еду по стоимости.
⦁	Добавить возможность для просмотра всей еды со всех заведений и отсортировать по возрастанию по цене.
⦁	Добавить возможность для просмотра использованных ингредиентов на одну порцию еды среди одного заведения и отсортировать их по возрастанию на вес.
⦁	Реализовать возможность создания продукта/еды/заведения во время выполнения программы. 
⦁	Реализовать возможность редактирования продукта/еды/заведения во время выполнения программы.
⦁	Бонус. Добавить возможность генерации отчета в текстовом файле (формат txt), где будет отображена вся еда со всех магазинов. Примерный вид отчета должен быть таким:	

Заведение,Повар,Еда,Цена,Себестоимость
Rest Ivleva,Ivlev,Pizza Half-Vegan,3000,4240
Putin Kitchen,Prigojin,Pizza Half-Vegan,6000,4240
Putin Kitchen,Prigojin,Apple Slices,300,1000
Nusret,Nusret,Golden Burger,20000,11940
Nusret,Nusret,Pizza Half-Vegan,6000,4240


