Ï
xD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos\Controllers\ClienteController.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Controllers% 0
{ 
public		 

class		 
ClienteController		 "
:		# $
ApiControllerBase		% 6
{

 
public 
ClienteController  
(  !
	IMediator! *
mediator+ 3
)3 4
:5 6
base7 ;
(; <
mediator< D
)D E
{F G
}H I
[ 	
HttpGet	 
] 
public 
Task 
< 
IActionResult !
>! "#
BuscarClientesPorFiltro# :
(: ;
[; <
	FromQuery< E
]E F'
BuscarClientesFiltroRequestG b
requestc j
)j k
{ 	
return 
	_mediator 
. 
Send !
(! "
request" )
)) *
;* +
} 	
[ 	
HttpPut	 
] 
public 
Task 
< 
IActionResult !
>! "
CriarCliente# /
(/ 0
[0 1
FromBody1 9
]9 :!
AlterarClienteRequest; P
requestQ X
)X Y
{ 	
return 
	_mediator 
. 
Send !
(! "
request" )
)) *
;* +
} 	
[ 	
HttpPost	 
] 
public 
Task 
< 
IActionResult !
>! "
CriarCliente# /
(/ 0
[0 1
FromBody1 9
]9 :
CriarClienteRequest; N
requestO V
)V W
{ 	
return 
	_mediator 
. 
Send !
(! "
request" )
)) *
;* +
} 	
} 
} „
vD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos\Controllers\LoginController.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Controllers% 0
{ 
[

 
ApiController

 
]

 
[ 
Route 

(
 
$str  
)  !
]! "
public 

class 
LoginController  
:! "
ControllerBase# 1
{ 
private 
readonly 
	IMediator "
	_mediator# ,
;, -
public 
LoginController 
( 
	IMediator (
mediator) 1
)1 2
{ 	
	_mediator 
= 
mediator  
;  !
} 	
[ 	
HttpPost	 
] 
public 
async 
Task 
< 
IActionResult '
>' (
Login) .
(. /
[/ 0
FromBody0 8
]8 9 
RealizarLoginRequest: N
loginO T
)T U
{ 	
return 
await 
	_mediator "
." #
Send# '
(' (
login( -
)- .
;. /
} 	
} 
} ®	
wD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos\Controllers\PedidoController.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Controllers% 0
{		 
public

 

class

 
PedidoController

 !
:

" #
ApiControllerBase

$ 5
{ 
public 
PedidoController 
(  
	IMediator  )
mediator* 2
)2 3
:4 5
base6 :
(: ;
mediator; C
)C D
{E F
}G H
[ 	
HttpPost	 
] 
[ 	
AllowAnonymous	 
] 
public 
Task 
< 
IActionResult !
>! "
CriarPedido# .
(. /
[/ 0
FromBody0 8
]8 9
CriarPedidoRequest: L
requestM T
)T U
{ 	
return 
	_mediator 
. 
Send !
(! "
request" )
)) *
;* +
} 	
} 
} ¦
xD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos\Controllers\ProdutoController.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Controllers% 0
{		 
public

 

class

 
ProdutoController

 "
:

# $
ApiControllerBase

% 6
{ 
public 
ProdutoController  
(  !
	IMediator! *
mediator+ 3
)3 4
:5 6
base7 ;
(; <
mediator< D
)D E
{F G
}H I
[ 	
HttpGet	 
] 
[ 	
AllowAnonymous	 
] 
public 
Task 
< 
IActionResult !
>! ""
BuscarProdutoPorFiltro# 9
(9 :
[: ;
	FromQuery; D
]D E'
BuscarProdutosFiltroRequestF a
requestb i
)i j
{ 	
return 
	_mediator 
. 
Send !
(! "
request" )
)) *
;* +
} 	
[ 	
HttpPost	 
] 
public 
Task 
< 
IActionResult !
>! "
CriarProduto# /
(/ 0
[0 1
FromBody1 9
]9 :
CriarProdutoRequest; N
requestO V
)V W
{ 	
return 
	_mediator 
. 
Send !
(! "
request" )
)) *
;* +
} 	
} 
} ù
xD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos\Controllers\UsuarioController.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
.$ %
Controllers% 0
{ 
public

 

class

 
UsuarioController

 "
:

# $
ApiControllerBase

% 6
{ 
public 
UsuarioController  
(  !
	IMediator! *
mediator+ 3
)3 4
:4 5
base6 :
(: ;
mediator; C
)C D
{E F
}G H
[ 	
HttpPost	 
] 
public 
Task 
< 
IActionResult !
>! "
CriarUsuario# /
(/ 0
[0 1
FromBody1 9
]9 :
CriarUsuarioRequest; N
requestO V
)V W
{ 	
return 
	_mediator 
. 
Send !
(! "
request" )
)) *
;* +
} 	
} 
} æ

bD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos\Program.cs
	namespace

 	
Coladel


 
.

 
GerenciadorPedidos

 $
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
; 
} 
} êN
bD:\GitHub\gerenciador-pedidos-api\Coladel.GerenciadorPedidos\Coladel.GerenciadorPedidos\Startup.cs
	namespace 	
Coladel
 
. 
GerenciadorPedidos $
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services 
. 
AddCors 
( 
c 
=> !
{ 
c   
.   
	AddPolicy   
(   
$str   )
,  ) *
options  + 2
=>  3 5
options  6 =
.  = >
AllowAnyOrigin  > L
(  L M
)  M N
)  N O
;  O P
}!! 
)!! 
;!! 
services## 
.## 
AddDbContext## !
<##! " 
ApplicationDbContext##" 6
>##6 7
(##7 8
options##8 ?
=>##@ B
{$$ 
var%% 
connetionString%% #
=%%$ %
Configuration%%& 3
.%%3 4
GetConnectionString%%4 G
(%%G H
$str%%H [
)%%[ \
;%%\ ]
options&& 
.&& 
UseMySql&&  
(&&  !
connetionString&&! 0
,&&0 1
ServerVersion&&2 ?
.&&? @

AutoDetect&&@ J
(&&J K
connetionString&&K Z
)&&Z [
)&&[ \
;&&\ ]
}'' 
)'' 
;'' 
services)) 
.)) 
AddControllers)) #
())# $
)))$ %
.** '
ConfigureApiBehaviorOptions** ,
(**, -
options**- 4
=>**5 7
{++ 
options,, 
.,, +
SuppressModelStateInvalidFilter,, ;
=,,< =
true,,> B
;,,B C
}-- 
)-- 
;-- 
var// 
assembly// 
=// 
	AppDomain// $
.//$ %
CurrentDomain//% 2
.//2 3
Load//3 7
(//7 8
$str//8 M
)//M N
;//N O
services00 
.00 

AddMediatR00 
(00  
assembly00  (
)00( )
;00) *
DependencyInjector22 
.22 
ConfigureServices22 0
(220 1
services221 9
)229 :
;22: ;
services44 
.44 
AddSwaggerGen44 "
(44" #
c44# $
=>44% '
{55 
c66 
.66 !
AddSecurityDefinition66 '
(66' (
$str66( 0
,660 1
new662 5!
OpenApiSecurityScheme666 K
{77 
Description88 
=88  !
$str88" M
,88M N
Name99 
=99 
$str99 *
,99* +
In:: 
=:: 
ParameterLocation:: *
.::* +
Header::+ 1
,::1 2
Type;; 
=;; 
SecuritySchemeType;; -
.;;- .
ApiKey;;. 4
,;;4 5
Scheme<< 
=<< 
$str<< %
}== 
)== 
;== 
c?? 
.?? "
AddSecurityRequirement?? (
(??( )
new??) ,&
OpenApiSecurityRequirement??- G
{@@ 
{AA 
newBB !
OpenApiSecuritySchemeBB 0
{CC 
	ReferenceDD $
=DD% &
newDD' *
OpenApiReferenceDD+ ;
{EE 
TypeFF #
=FF$ %
ReferenceTypeFF& 3
.FF3 4
SecuritySchemeFF4 B
,FFB C
IdGG !
=GG" #
$strGG$ ,
}HH 
}II 
,II 
ArrayJJ 
.JJ 
EmptyJJ "
<JJ" #
stringJJ# )
>JJ) *
(JJ* +
)JJ+ ,
}KK 
}LL 
)LL 
;LL 
cNN 
.NN 

SwaggerDocNN 
(NN 
$strNN !
,NN! "
newNN# &
OpenApiInfoNN' 2
{NN3 4
TitleNN5 :
=NN; <
$strNN= a
,NNa b
VersionNNc j
=NNk l
$strNNm q
}NNr s
)NNs t
;NNt u
varOO 
xmlFileOO 
=OO 
$"OO  
{OO  !
AssemblyOO! )
.OO) * 
GetExecutingAssemblyOO* >
(OO> ?
)OO? @
.OO@ A
GetNameOOA H
(OOH I
)OOI J
.OOJ K
NameOOK O
}OOO P
$strOOP T
"OOT U
;OOU V
varPP 
xmlPathPP 
=PP 
PathPP "
.PP" #
CombinePP# *
(PP* +

AppContextPP+ 5
.PP5 6
BaseDirectoryPP6 C
,PPC D
xmlFilePPE L
)PPL M
;PPM N
cQQ 
.QQ 
IncludeXmlCommentsQQ $
(QQ$ %
xmlPathQQ% ,
)QQ, -
;QQ- .
}RR 
)RR 
;RR 
servicesSS 
.SS 
AddAuthenticationSS &
(SS& '
xSS' (
=>SS) +
{TT 
xUU 
.UU %
DefaultAuthenticateSchemeUU +
=UU, -
JwtBearerDefaultsUU. ?
.UU? @ 
AuthenticationSchemeUU@ T
;UUT U
xVV 
.VV "
DefaultChallengeSchemeVV (
=VV) *
JwtBearerDefaultsVV+ <
.VV< = 
AuthenticationSchemeVV= Q
;VVQ R
}WW 
)WW 
.XX 
AddJwtBearerXX 
(XX 
xXX 
=>XX 
{YY 
xZZ 
.ZZ  
RequireHttpsMetadataZZ &
=ZZ' (
falseZZ) .
;ZZ. /
x[[ 
.[[ 
	SaveToken[[ 
=[[ 
true[[ "
;[[" #
x\\ 
.\\ %
TokenValidationParameters\\ +
=\\, -
new\\. 1
	Microsoft\\2 ;
.\\; <
IdentityModel\\< I
.\\I J
Tokens\\J P
.\\P Q%
TokenValidationParameters\\Q j
{]] $
ValidateIssuerSigningKey^^ ,
=^^- .
true^^/ 3
,^^3 4
IssuerSigningKey__ $
=__% &
new__' * 
SymmetricSecurityKey__+ ?
(__? @
Authentication__@ N
.__N O
AuthenticationJwt__O `
.__` a)
InitConfigureJwtAuthetication__a ~
(__~ 
Configuration	__ Œ
.
__Œ 

GetSection
__ —
(
__— ˜
$str
__˜ ²
)
__² ³
.
__³ ´
Value
__´ ¹
)
__¹ º
)
__º »
,
__» ¼
ValidateIssuer`` "
=``# $
false``% *
,``* +
ValidateAudienceaa $
=aa% &
falseaa' ,
}bb 
;bb 
}cc 
)cc 
;cc 
}dd 	
publicff 
voidff 
	Configureff 
(ff 
IApplicationBuilderff 1
appff2 5
,ff5 6
IWebHostEnvironmentff7 J
envffK N
)ffN O
{gg 	
apphh 
.hh 
UseCorshh 
(hh 
xhh 
=>hh 
xhh 
.ii 
AllowAnyMethodii 
(ii  
)ii  !
.jj 
AllowAnyHeaderjj 
(jj  
)jj  !
.kk 
SetIsOriginAllowedkk #
(kk# $
originkk$ *
=>kk+ -
truekk. 2
)kk2 3
.ll 
AllowCredentialsll !
(ll! "
)ll" #
)ll# $
;ll$ %
ifnn 
(nn 
envnn 
.nn 
IsDevelopmentnn !
(nn! "
)nn" #
)nn# $
{oo 
apppp 
.pp %
UseDeveloperExceptionPagepp -
(pp- .
)pp. /
;pp/ 0
}qq 
appss 
.ss 
UseHttpsRedirectionss #
(ss# $
)ss$ %
;ss% &
apptt 
.tt 

UseSwaggertt 
(tt 
ctt 
=>tt 
{uu 
cvv 
.vv 
SerializeAsV2vv 
=vv  !
truevv" &
;vv& '
cww 
.ww 
RouteTemplateww 
=ww  !
$strww" G
;wwG H
}xx 
)xx 
;xx 
appzz 
.zz 
UseSwaggerUIzz 
(zz 
czz 
=>zz !
{{{ 
c|| 
.|| 
SwaggerEndpoint|| !
(||! "
$str||" ;
,||; <
$str||= a
)||a b
;||b c
c}} 
.}} 
RoutePrefix}} 
=}} 
string}}  &
.}}& '
Empty}}' ,
;}}, -
c~~ 
.~~ 
EnableFilter~~ 
(~~ 
)~~  
;~~  !
} 
) 
; 
app
 
.
 

UseRouting
 
(
 
)
 
;
 
app
ƒƒ 
.
ƒƒ 
UseAuthentication
ƒƒ !
(
ƒƒ! "
)
ƒƒ" #
;
ƒƒ# $
app
„„ 
.
„„ 
UseAuthorization
„„  
(
„„  !
)
„„! "
;
„„" #
app
†† 
.
†† 
UseEndpoints
†† 
(
†† 
	endpoints
†† &
=>
††' )
{
‡‡ 
	endpoints
ˆˆ 
.
ˆˆ 
MapControllers
ˆˆ (
(
ˆˆ( )
)
ˆˆ) *
;
ˆˆ* +
}
‰‰ 
)
‰‰ 
;
‰‰ 
}
ŠŠ 	
}
‹‹ 
}ŒŒ 