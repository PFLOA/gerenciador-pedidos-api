Û
zD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Data\ApplicationDbContext.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +
Data+ /
{ 
public 
class	  
ApplicationDbContext #
:$ %
	DbContext& /
{		 
public

 

DbSet

 
<

 
Usuario

 
>

 
Usuario

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 

DbSet 
< 
Produto 
> 
Produto !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 

DbSet 
< 
Cliente 
> 
Cliente !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
 
ApplicationDbContext 
(  
DbContextOptions  0
<0 1 
ApplicationDbContext1 E
>E F
optionsG N
)N O
:P Q
baseR V
(V W
optionsW ^
)^ _
{` a
}b c
	protected 
override 
void 
OnModelCreating +
(+ ,
ModelBuilder, 8
modelBuilder9 E
)E F
{ 
modelBuilder 
. 
ApplyConfiguration %
(% &
new& )
UsuarioMapping* 8
(8 9
)9 :
): ;
;; <
modelBuilder 
. 
ApplyConfiguration %
(% &
new& )
ProdutoMapping* 8
(8 9
)9 :
): ;
;; <
modelBuilder 
. 
ApplyConfiguration %
(% &
new& )
ClienteMapping* 8
(8 9
)9 :
): ;
;; <
base 

.
 
OnModelCreating 
( 
modelBuilder '
)' (
;( )
} 
} 
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
} ‡
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
} «
pD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Data\Repository.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
.* +
Data+ /
{ 
public 

class 

Repository 
< 
	TEntidade %
>% &
:' (
IRepository) 4
<4 5
	TEntidade5 >
>> ?
where@ E
	TEntidadeF O
:P Q
classR W
{		 
	protected

 
DbSet

 
<

 
	TEntidade

 !
>

! "
Set

# &
{

' (
get

) ,
;

, -
private

. 5
set

6 9
;

9 :
}

; <
	protected  
ApplicationDbContext &
context' .
;. /
public 

Repository 
(  
ApplicationDbContext .
	dbContext/ 8
)8 9
{ 	
context 
= 
	dbContext 
;  
Type 
tipo 
= 
typeof 
( 
	TEntidade (
)( )
;) *
MappingProperties 
( 
	dbContext '
,' (
tipo) -
)- .
;. /
} 	
private 
void 

Comparator 
(  
Object  &

fromObjeto' 1
,1 2
PropertyInfo3 ?
propertyInfo@ L
,L M
TypeN R
toObjetoS [
)[ \
{ 	
var 
toObjetoName 
= 
toObjeto '
.' (
Name( ,
;, -
var 
found 
= 
toObjetoName $
==% '
propertyInfo( 4
.4 5
Name5 9
?: ;
propertyInfo< H
:I J
nullK O
;O P
if 
( 
found 
!= 
null 
) 
Set 
= 
propertyInfo "
." #
GetValue# +
(+ ,

fromObjeto, 6
)6 7
as8 :
DbSet; @
<@ A
	TEntidadeA J
>J K
;K L
} 	
public 
void 
MappingProperties %
(% &
Object& ,

fromObjeto- 7
,7 8
Type9 =
toObjeto> F
)F G
{ 	
foreach 
( 
var 

properties #
in$ &

fromObjeto' 1
.1 2
GetType2 9
(9 :
): ;
.; <
GetProperties< I
(I J
)J K
)K L
{   

Comparator!! 
(!! 

fromObjeto!! %
,!!% &

properties!!' 1
,!!1 2
toObjeto!!3 ;
)!!; <
;!!< =
}"" 
}## 	
}$$ 
}%% û
sD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\DependencyInjector.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Infra% *
{ 
public 
static	 
class 
DependencyInjector (
{ 
public 

static 
void 
ConfigureServices (
(( )
IServiceCollection) ;
services< D
)D E
{ 
services 
. 
	AddScoped 
< 
ILoginRepository )
,) *
LoginRepository+ :
>: ;
(; <
)< =
;= >
services 
. 
	AddScoped 
< 
IUsuarioRepository +
,+ ,
UsuarioRepository- >
>> ?
(? @
)@ A
;A B
services 
. 
	AddScoped 
< 
IProdutoRepository +
,+ ,
ProdutoRepository- >
>> ?
(? @
)@ A
;A B
services 
. 
	AddScoped 
< 
IClienteRepository +
,+ ,
ClienteRepository- >
>> ?
(? @
)@ A
;A B
} 
} 
} ⁄
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
,8 9
IClienteRepository: L
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
} 	
public 
Cliente 
CriarCliente #
(# $#
CriarClienteRequestBody$ ;
cliente< C
)C D
{ 	
var 
response 
= 
Set 
. 
Add "
(" #
cliente# *
.* +
ToModel+ 2
(2 3
)3 4
)4 5
;5 6
context 
. 
SaveChanges 
(  
)  !
;! "
return 
response 
. 
Entity "
;" #
} 	
} 
} ¬
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
} ‘
}D:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos.Infra\Repository\ProdutoRepository.cs
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
ProdutoRepository "
:# $

Repository% /
</ 0
Produto0 7
>7 8
,8 9
IProdutoRepository: L
{ 
public 
ProdutoRepository  
(  ! 
ApplicationDbContext! 5
context6 =
)= >
:? @
baseA E
(E F
contextF M
)M N
{O P
}Q R
public 

IQueryable 
< 
Produto !
>! "#
BuscarProdutosPorFiltro# :
(: ;&
BuscarProdutosFiltroFilter; U
filterV \
)\ ]
{ 	
return 
Set 
. !
FiltrarPorNomeProduto ,
(, -
filter- 3
.3 4
NomeProduto4 ?
)? @
. "
FiltrarPorDataCadastro '
(' (
filter( .
.. /
DataCadastro/ ;
); <
;< =
} 	
public 
Produto 
CriarProduto #
(# $#
CriarProdutoRequestBody$ ;
produto< C
)C D
{ 	
var 
retorno 
= 
Set 
. 
Add !
(! "
produto" )
.) *
ToModel* 1
(1 2
)2 3
)3 4
;4 5
context 
. 
SaveChanges 
(  
)  !
;! "
return 
retorno 
. 
Entity !
;! "
} 	
} 
} ˘
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