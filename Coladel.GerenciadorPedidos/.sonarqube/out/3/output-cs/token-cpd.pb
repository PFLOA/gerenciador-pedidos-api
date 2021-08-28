¥
zD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Data\ApplicationDbContext.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +
Data+ /
{ 
public 

class  
ApplicationDbContext %
:& '
	DbContext( 1
{ 
public		 
DbSet		 
<		 
Usuario		 
>		 
Usuario		 %
{		& '
get		( +
;		+ ,
set		- 0
;		0 1
}		2 3
public

 
DbSet

 
<

 
Produto

 
>

 
Produto

 %
{

& '
get

( +
;

+ ,
set

- 0
;

0 1
}

2 3
public 
DbSet 
< 
Cliente 
> 
Cliente %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public  
ApplicationDbContext #
(# $
DbContextOptions$ 4
<4 5 
ApplicationDbContext5 I
>I J
optionsK R
)R S
:T U
baseV Z
(Z [
options[ b
)b c
{d e
}f g
	protected 
override 
void 
OnModelCreating  /
(/ 0
ModelBuilder0 <
modelBuilder= I
)I J
{ 	
modelBuilder 
. 
ApplyConfiguration +
(+ ,
new, /
UsuarioMapping0 >
(> ?
)? @
)@ A
;A B
modelBuilder 
. 
ApplyConfiguration +
(+ ,
new, /
ProdutoMapping0 >
(> ?
)? @
)@ A
;A B
modelBuilder 
. 
ApplyConfiguration +
(+ ,
new, /
ClienteMapping0 >
(> ?
)? @
)@ A
;A B
modelBuilder 
. 
ApplyConfiguration +
(+ ,
new, /
PedidosMapping0 >
(> ?
)? @
)@ A
;A B
base 
. 
OnModelCreating  
(  !
modelBuilder! -
)- .
;. /
} 	
} 
}   œ
|D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Data\Mapping\ClienteMapping.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +
Data+ /
./ 0
Mapping0 7
{		 
public

 
class

	 
ClienteMapping

 
:

 $
IEntityTypeConfiguration

  8
<

8 9
Cliente

9 @
>

@ A
{ 
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
Cliente, 3
>3 4
builder5 <
)< =
{ 
builder 
. 
ToTable 
( 
$str 
)  
;  !
builder 
. 
HasKey 
( 
p 
=> 
p 
. 
Id 
) 
;  
builder 
. 
Property 
( 
p 
=> 
p 
. 
Id  
)  !
.! "
HasColumnName" /
(/ 0
$str0 4
)4 5
;5 6
builder 
. 
Property 
( 
p 
=> 
p 
. 
Guid "
)" #
.# $
HasColumnName$ 1
(1 2
$str2 8
)8 9
.9 :
HasColumnType: G
(G H
$strH Z
)Z [
.[ \
HasDefaultValueSql\ n
<n o
Guido s
>s t
(t u
)u v
;v w
builder 
. 
Property 
( 
p 
=> 
p 
. 
DataCadastro *
)* +
.+ ,
HasColumnName, 9
(9 :
$str: I
)I J
;J K
builder 
. 
Property 
( 
p 
=> 
p 
. 
NomeCliente )
)) *
.* +
HasColumnName+ 8
(8 9
$str9 G
)G H
;H I
} 
} 
} ·
|D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Data\Mapping\PedidosMapping.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +
Data+ /
./ 0
Mapping0 7
{		 
public

 

class

 
PedidosMapping

 
:

  !$
IEntityTypeConfiguration

" :
<

: ;
Pedido

; A
>

A B
{ 
public 
void 
	Configure 
( 
EntityTypeBuilder /
</ 0
Pedido0 6
>6 7
builder8 ?
)? @
{ 	
builder 
. 
ToTable 
( 
$str %
)% &
;& '
builder 
. 
HasKey 
( 
p 
=> 
p  !
.! "
Id" $
)$ %
;% &
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Id$ &
)& '
.' (
HasColumnName( 5
(5 6
$str6 :
): ;
;; <
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Guid$ (
)( )
.) *
HasColumnName* 7
(7 8
$str8 >
)> ?
.? @
HasColumnType@ M
(M N
$strN `
)` a
.a b
HasDefaultValueSqlb t
<t u
Guidu y
>y z
(z {
){ |
;| }
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
DataCadastro$ 0
)0 1
.1 2
HasColumnName2 ?
(? @
$str@ O
)O P
;P Q
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
NF$ &
)& '
.' (
HasColumnName( 5
(5 6
$str6 :
): ;
;; <
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Observacoes$ /
)/ 0
.0 1
HasColumnName1 >
(> ?
$str? L
)L M
;M N
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
ProdutosList$ 0
)0 1
.1 2
HasJsonConversion2 C
<C D
ListD H
<H I
ProdutoI P
>P Q
>Q R
(R S
)S T
.T U
HasColumnNameU b
(b c
$strc m
)m n
;n o
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
StatusPedido$ 0
)0 1
.1 2
HasColumnName2 ?
(? @
$str@ H
)H I
;I J
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Total$ )
)) *
.* +
HasColumnName+ 8
(8 9
$str9 @
)@ A
;A B
builder 
. 
HasOne 
( 
p 
=> 
p  !
.! "
Cliente" )
)) *
.* +
WithMany+ 3
(3 4
)4 5
.5 6
HasForeignKey6 C
(C D
cD E
=>F H
cI J
.J K
	IdClienteK T
)T U
;U V
} 	
} 
} ‡
|D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Data\Mapping\ProdutoMapping.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +
Data+ /
./ 0
Mapping0 7
{ 
public 

class 
ProdutoMapping 
:  !$
IEntityTypeConfiguration" :
<: ;
Produto; B
>B C
{		 
public

 
void

 
	Configure

 
(

 
EntityTypeBuilder

 /
<

/ 0
Produto

0 7
>

7 8
builder

9 @
)

@ A
{ 	
builder 
. 
ToTable 
( 
$str &
)& '
;' (
builder 
. 
HasKey 
( 
p 
=> 
p  !
.! "
Id" $
)$ %
;% &
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Id$ &
)& '
.' (
HasColumnName( 5
(5 6
$str6 :
): ;
;; <
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Guid$ (
)( )
.) *
HasColumnName* 7
(7 8
$str8 >
)> ?
.? @
HasColumnType@ M
(M N
$strN `
)` a
.a b
HasDefaultValueSqlb t
<t u
Guidu y
>y z
(z {
){ |
;| }
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
DataCadastro$ 0
)0 1
.1 2
HasColumnName2 ?
(? @
$str@ O
)O P
;P Q
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
NomeProduto$ /
)/ 0
.0 1
HasColumnName1 >
(> ?
$str? M
)M N
;N O
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Preco$ )
)) *
.* +
HasColumnName+ 8
(8 9
$str9 @
)@ A
;A B
} 	
} 
} ˛
|D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Data\Mapping\UsuarioMapping.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +
Data+ /
./ 0
Mapping0 7
{ 
public 

class 
UsuarioMapping 
:  !$
IEntityTypeConfiguration" :
<: ;
Usuario; B
>B C
{		 
public

 
void

 
	Configure

 
(

 
EntityTypeBuilder

 /
<

/ 0
Usuario

0 7
>

7 8
builder

9 @
)

@ A
{ 	
builder 
. 
ToTable 
( 
$str &
)& '
;' (
builder 
. 
HasKey 
( 
p 
=> 
p  !
.! "
Id" $
)$ %
;% &
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Id$ &
)& '
.' (
HasColumnName( 5
(5 6
$str6 :
): ;
;; <
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Guid$ (
)( )
.) *
HasColumnName* 7
(7 8
$str8 >
)> ?
.? @
HasColumnType@ M
(M N
$strN `
)` a
.a b
HasDefaultValueSqlb t
<t u
Guidu y
>y z
(z {
){ |
;| }
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
DataCadastro$ 0
)0 1
.1 2
HasColumnName2 ?
(? @
$str@ O
)O P
;P Q
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Nome$ (
)( )
.) *
HasColumnName* 7
(7 8
$str8 >
)> ?
;? @
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Senha$ )
)) *
.* +
HasColumnName+ 8
(8 9
$str9 @
)@ A
;A B
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
Email$ )
)) *
.* +
HasColumnName+ 8
(8 9
$str9 @
)@ A
;A B
builder 
. 
Property 
( 
p 
=> !
p" #
.# $
UserName$ ,
), -
.- .
HasColumnName. ;
(; <
$str< G
)G H
;H I
} 	
} 
} Ø)
pD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Data\Repository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +
Data+ /
{		 
public

 

class

 

Repository

 
<

 
	TEntidade

 %
>

% &
:

' (
IRepository

) 4
<

4 5
	TEntidade

5 >
>

> ?
where

@ E
	TEntidade

F O
:

P Q
Entity

R X
{ 
	protected 
DbSet 
< 
	TEntidade !
>! "
Set# &
{' (
get) ,
;, -
private. 5
set6 9
;9 :
}; <
	protected  
ApplicationDbContext &
context' .
;. /
public 

Repository 
(  
ApplicationDbContext .
	dbContext/ 8
)8 9
{ 	
context 
= 
	dbContext 
;  
Type 
tipo 
= 
typeof 
( 
	TEntidade (
)( )
;) *
MappingProperties 
( 
	dbContext '
,' (
tipo) -
)- .
;. /
} 	
public 
	TEntidade 
BuscarPorGuid &
(& '
Guid' +
guid, 0
)0 1
{ 	
var 
result 
= 
Set 
. 
FirstOrDefault +
(+ ,
p, -
=>. 0
p1 2
.2 3
Guid3 7
==8 :
guid; ?
)? @
;@ A
return 
result 
; 
} 	
public 
	TEntidade 
Criar 
( 
	TEntidade (
entidade) 1
)1 2
{ 	
var 
result 
= 
Set 
. 
Add  
(  !
entidade! )
)) *
;* +
context 
. 
SaveChanges 
(  
)  !
;! "
return 
result 
. 
Entity  
;  !
} 	
public   
Guid   
Alterar   
(   
	TEntidade   %
entidade  & .
)  . /
{!! 	
var"" 
result"" 
="" 
Set"" 
."" 
Update"" #
(""# $
entidade""$ ,
)"", -
;""- .
context## 
.## 
SaveChanges## 
(##  
)##  !
;##! "
return$$ 
result$$ 
.$$ 
Entity$$  
.$$  !
Guid$$! %
;$$% &
}%% 	
public&& 
Guid&& 
Remover&& 
(&& 
	TEntidade&& %
entidade&&& .
)&&. /
{'' 	
var(( 
result(( 
=(( 
Set(( 
.(( 
Remove(( #
(((# $
entidade(($ ,
)((, -
;((- .
context)) 
.)) 
SaveChanges)) 
())  
)))  !
;))! "
return** 
result** 
.** 
Entity**  
.**  !
Guid**! %
;**% &
}++ 	
private-- 
void-- 

Comparator-- 
(--  
Object--  &

fromObjeto--' 1
,--1 2
PropertyInfo--3 ?
propertyInfo--@ L
,--L M
Type--N R
toObjeto--S [
)--[ \
{.. 	
var// 
toObjetoName// 
=// 
toObjeto// '
.//' (
Name//( ,
;//, -
var00 
found00 
=00 
toObjetoName00 $
==00% '
propertyInfo00( 4
.004 5
Name005 9
?00: ;
propertyInfo00< H
:00I J
null00K O
;00O P
if22 
(22 
found22 
!=22 
null22 
)22 
Set33 
=33 
propertyInfo33 "
.33" #
GetValue33# +
(33+ ,

fromObjeto33, 6
)336 7
as338 :
DbSet33; @
<33@ A
	TEntidade33A J
>33J K
;33K L
}44 	
private66 
void66 
MappingProperties66 &
(66& '
Object66' -

fromObjeto66. 8
,668 9
Type66: >
toObjeto66? G
)66G H
{77 	
foreach88 
(88 
var88 

properties88 #
in88$ &

fromObjeto88' 1
.881 2
GetType882 9
(889 :
)88: ;
.88; <
GetProperties88< I
(88I J
)88J K
)88K L
{99 

Comparator:: 
(:: 

fromObjeto:: %
,::% &

properties::' 1
,::1 2
toObjeto::3 ;
)::; <
;::< =
};; 
}<< 	
}== 
}>> Í
sD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\DependencyInjector.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
{ 
public 

static 
class 
DependencyInjector *
{ 
public 
static 
void 
ConfigureServices ,
(, -
IServiceCollection- ?
services@ H
)H I
{ 	
services 
. 
	AddScoped 
< 
ILoginRepository /
,/ 0
LoginRepository1 @
>@ A
(A B
)B C
;C D
services 
. 
	AddScoped 
< 
IUsuarioRepository 1
,1 2
UsuarioRepository3 D
>D E
(E F
)F G
;G H
services 
. 
	AddScoped 
< 
IProdutoRepository 1
,1 2
ProdutoRepository3 D
>D E
(E F
)F G
;G H
services 
. 
	AddScoped 
< 
IPedidoRepository 0
,0 1
PedidoRepository2 B
>B C
(C D
)D E
;E F
services 
. 
	AddScoped 
< 
IRepository *
,* +
ClienteRepository, =
>= >
(> ?
)? @
;@ A
} 	
} 
} È

}D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Repository\ClienteRepository.cs
	namespace		 	
Coladel		
 
.		 
GerenciadorPedidos		 $
.		$ %
Infra		% *
.		* +

Repository		+ 5
{

 
public 

class 
ClienteRepository "
:# $

Repository% /
</ 0
Cliente0 7
>7 8
,8 9
IRepository: E
{ 
public 
ClienteRepository  
(  ! 
ApplicationDbContext! 5
	dbContext6 ?
)? @
:A B
baseC G
(G H
	dbContextH Q
)Q R
{S T
}U V
public 

IQueryable 
< 
Cliente !
>! "#
BuscarClientesPorFiltro# :
(: ;&
BuscarClientesFiltroFilter; U
filterV \
)\ ]
{ 	
return 
Set 
. !
FiltrarPorNomeCliente ,
(, -
filter- 3
.3 4
NomeCliente4 ?
)? @
. "
FiltrarPorDataCadastro +
(+ ,
filter, 2
.2 3
DataCadastro3 ?
)? @
;@ A
} 	
} 
} ¬
{D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Repository\LoginRepository.cs
	namespace		 	
Coladel		
 
.		 
GerenciadorPedidos		 $
.		$ %
Infra		% *
.		* +

Repository		+ 5
{

 
public 

class 
LoginRepository  
:! "

Repository# -
<- .
Usuario. 5
>5 6
,6 7
ILoginRepository8 H
{ 
public 
LoginRepository 
(  
ApplicationDbContext 3
context4 ;
); <
:= >
base? C
(C D
contextD K
)K L
{L M
}N O
public 
Usuario 
	LoginUser  
(  !
string! '
userName( 0
,0 1
string2 8
senha9 >
)> ?
{ 	
Hash 
hash 
= 
new 
Hash  
(  !
SHA512! '
.' (
Create( .
(. /
)/ 0
)0 1
;1 2
string 
retorno 
= 
hash !
.! "
VerificarSenha" 0
(0 1
senha1 6
)6 7
;7 8
Usuario 
usuario 
= 
Set !
.! "
FirstOrDefault" 0
(0 1
p1 2
=>3 5
p6 7
.7 8
UserName8 @
==A C
userNameD L
)L M
;M N
string 
salt 
= 
Hash 
. 

CreateSalt )
() *
usuario* 1
.1 2
Guid2 6
.6 7
ToInt327 >
(> ?
)? @
)@ A
;A B
usuario 
= 
Set 
. 
FirstOrDefault (
(( )
p) *
=>+ -
p. /
./ 0
UserName0 8
==9 ;
userName< D
&&E G
pH I
.I J
SenhaJ O
==P R
$"S U
{U V
retornoV ]
}] ^
{^ _
salt_ c
}c d
"d e
)e f
;f g
return 
usuario 
; 
} 	
} 
} ù
|D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Repository\PedidoRepository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +

Repository+ 5
{ 
public 

class 
PedidoRepository !
:" #

Repository$ .
<. /
Pedido/ 5
>5 6
,6 7
IPedidoRepository8 I
{ 
public		 
PedidoRepository		 
(		   
ApplicationDbContext		  4
context		5 <
)		< =
:		> ?
base		@ D
(		D E
context		E L
)		L M
{		N O
}		P Q
}

 
} Ï

}D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Repository\ProdutoRepository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +

Repository+ 5
{		 
public

 

class

 
ProdutoRepository

 "
:

# $

Repository

% /
<

/ 0
Produto

0 7
>

7 8
,

8 9
IProdutoRepository

: L
{ 
public 
ProdutoRepository  
(  ! 
ApplicationDbContext! 5
context6 =
)= >
:? @
baseA E
(E F
contextF M
)M N
{O P
}Q R
public 

IQueryable 
< 
Produto !
>! "#
BuscarProdutosPorFiltro# :
(: ;&
BuscarProdutosFiltroFilter; U
filterV \
)\ ]
{ 	
return 
Set 
. !
FiltrarPorNomeProduto ,
(, -
filter- 3
.3 4
NomeProduto4 ?
)? @
. "
FiltrarPorDataCadastro '
(' (
filter( .
.. /
DataCadastro/ ;
); <
;< =
} 	
} 
} ˘
ëD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Repository\QueryExtensions\ClienteQueryExtension.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +

Repository+ 5
.5 6
QueryExtensions6 E
{ 
public		 

static		 
class		 !
ClienteQueryExtension		 -
{

 
public 
static 

IQueryable  
<  !
Cliente! (
>( )!
FiltrarPorNomeCliente* ?
(? @
this@ D

IQueryableE O
<O P
ClienteP W
>W X
queryY ^
,^ _
string` f
nomeg k
)k l
{ 	
if 
( 
! 
string 
. 
IsNullOrEmpty %
(% &
nome& *
)* +
)+ ,
return- 3
query4 9
.9 :
Where: ?
(? @
p@ A
=>B D
pE F
.F G
NomeClienteG R
.R S
ToLowerS Z
(Z [
)[ \
.\ ]
Contains] e
(e f
nomef j
.j k
ToLowerk r
(r s
)s t
)t u
)u v
;v w
return 
query 
; 
} 	
public 
static 

IQueryable  
<  !
Cliente! (
>( )"
FiltrarPorDataCadastro* @
(@ A
thisA E

IQueryableF P
<P Q
ClienteQ X
>X Y
queryZ _
,_ `
DateTimea i
dataCadastroj v
)v w
{ 	
if 
( 
dataCadastro 
!= 
DateTime  (
.( )
MinValue) 1
)1 2
return3 9
query: ?
.? @
Where@ E
(E F
pF G
=>H J
pK L
.L M
DataCadastroM Y
.Y Z
DateZ ^
==_ a
dataCadastrob n
.n o
Dateo s
)s t
;t u
return 
query 
; 
} 	
} 
} Ù
èD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Repository\QueryExtensions\LoginQueryExtension.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +

Repository+ 5
.5 6
QueryExtensions6 E
{ 
public		 

static		 
class		 
LoginQueryExtension		 +
{

 
} 
} ˘
ëD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Repository\QueryExtensions\ProdutoQueryExtension.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +

Repository+ 5
.5 6
QueryExtensions6 E
{ 
public 

static 
class !
ProdutoQueryExtension -
{ 
public		 
static		 

IQueryable		  
<		  !
Produto		! (
>		( )!
FiltrarPorNomeProduto		* ?
(		? @
this		@ D

IQueryable		E O
<		O P
Produto		P W
>		W X
query		Y ^
,		^ _
string		` f
nome		g k
)		k l
{

 	
if 
( 
! 
string 
. 
IsNullOrEmpty %
(% &
nome& *
)* +
)+ ,
return- 3
query4 9
.9 :
Where: ?
(? @
p@ A
=>B D
pE F
.F G
NomeProdutoG R
.R S
ToLowerS Z
(Z [
)[ \
.\ ]
Contains] e
(e f
nomef j
.j k
ToLowerk r
(r s
)s t
)t u
)u v
;v w
return 
query 
; 
} 	
public 
static 

IQueryable  
<  !
Produto! (
>( )"
FiltrarPorDataCadastro* @
(@ A
thisA E

IQueryableF P
<P Q
ProdutoQ X
>X Y
queryZ _
,_ `
DateTimea i
dataCadastroj v
)v w
{ 	
if 
( 
dataCadastro 
!= 
DateTime  (
.( )
MinValue) 1
)1 2
return3 9
query: ?
.? @
Where@ E
(E F
pF G
=>H J
pK L
.L M
DataCadastroM Y
.Y Z
DateZ ^
==_ a
dataCadastrob n
.n o
Dateo s
)s t
;t u
return 
query 
; 
} 	
} 
} ä
}D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Repository\UsuarioRepository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +

Repository+ 5
{ 
public		 

class		 
UsuarioRepository		 "
:		# $

Repository		% /
<		/ 0
Usuario		0 7
>		7 8
,		8 9
IUsuarioRepository		: L
{

 
public 
UsuarioRepository  
(  ! 
ApplicationDbContext! 5
context6 =
)= >
:? @
baseA E
(E F
contextF M
)M N
{O P
}Q R
public 
Usuario 
CriarUsuario #
(# $#
CriarUsuarioRequestBody$ ;
usuario< C
)C D
{ 	
var 
retorno 
= 
Set 
. 
Add !
(! "
usuario" )
.) *
ToModel* 1
(1 2
)2 3
)3 4
;4 5
context 
. 
SaveChanges 
(  
)  !
;! "
return 
retorno 
. 
Entity !
;! "
} 	
} 
} 