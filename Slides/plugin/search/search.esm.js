var t,e,n="undefined"!=typeof globalThis?globalThis:"undefined"!=typeof window?window:"undefined"!=typeof global?global:"undefined"!=typeof self?self:{},r=function(t){try{return!!t()}catch(t){return!0}},o=!r((function(){return 7!==Object.defineProperty({},1,{get:function(){return 7}})[1]})),i=function(t){return t&&t.Math===Math&&t},u=i("object"==typeof globalThis&&globalThis)||i("object"==typeof window&&window)||i("object"==typeof self&&self)||i("object"==typeof n&&n)||function(){return this}()||n||Function("return this")(),c=!r((function(){var t=function(){}.bind();return"function"!=typeof t||t.hasOwnProperty("prototype")})),a=c,f=Function.prototype,l=f.call,s=a&&f.bind.bind(l,l),p=a?s:function(t){return function(){return l.apply(t,arguments)}},d="object"==typeof document&&document.all,g={all:d,IS_HTMLDDA:void 0===d&&void 0!==d},v=g.all,y=g.IS_HTMLDDA?function(t){return"function"==typeof t||t===v}:function(t){return"function"==typeof t},h=r,b=y,m=/#|\.prototype\./,x=function(t,e){var n=w[S(t)];return n===E||n!==O&&(b(e)?h(e):!!e)},S=x.normalize=function(t){return String(t).replace(m,".").toLowerCase()},w=x.data={},O=x.NATIVE="N",E=x.POLYFILL="P",j=x,R=y,I=g.all,P=g.IS_HTMLDDA?function(t){return"object"==typeof t?null!==t:R(t)||t===I}:function(t){return"object"==typeof t?null!==t:R(t)},T=String,C=y,_=function(t){try{return T(t)}catch(t){return"Object"}},A=TypeError,N=function(t){if(C(t))return t;throw new A(_(t)+" is not a function")},k=p,D=N,M=P,$=String,L=TypeError,F=function(t){if(M(t))return t;throw new L($(t)+" is not an object")},z=y,K=String,W=TypeError,B=function(t,e,n){try{return k(D(Object.getOwnPropertyDescriptor(t,e)[n]))}catch(t){}},U=F,Y=function(t){if("object"==typeof t||z(t))return t;throw new W("Can't set "+K(t)+" as a prototype")},H=Object.setPrototypeOf||("__proto__"in{}?function(){var t,e=!1,n={};try{(t=B(Object.prototype,"__proto__","set"))(n,[]),e=n instanceof Array}catch(t){}return function(n,r){return U(n),Y(r),e?t(n,r):n.__proto__=r,n}}():void 0),V=y,G=P,q=H,X={},J=P,Q=u.document,Z=J(Q)&&J(Q.createElement),tt=function(t){return Z?Q.createElement(t):{}},et=tt,nt=!o&&!r((function(){return 7!==Object.defineProperty(et("div"),"a",{get:function(){return 7}}).a})),rt=o&&r((function(){return 42!==Object.defineProperty((function(){}),"prototype",{value:42,writable:!1}).prototype})),ot=c,it=Function.prototype.call,ut=ot?it.bind(it):function(){return it.apply(it,arguments)},ct=u,at=y,ft=function(t,e){return arguments.length<2?(n=ct[t],at(n)?n:void 0):ct[t]&&ct[t][e];var n},lt=p({}.isPrototypeOf),st=u,pt="undefined"!=typeof navigator&&String(navigator.userAgent)||"",dt=st.process,gt=st.Deno,vt=dt&&dt.versions||gt&&gt.version,yt=vt&&vt.v8;yt&&(e=(t=yt.split("."))[0]>0&&t[0]<4?1:+(t[0]+t[1])),!e&&pt&&(!(t=pt.match(/Edge\/(\d+)/))||t[1]>=74)&&(t=pt.match(/Chrome\/(\d+)/))&&(e=+t[1]);var ht=e,bt=r,mt=u.String,xt=!!Object.getOwnPropertySymbols&&!bt((function(){var t=Symbol("symbol detection");return!mt(t)||!(Object(t)instanceof Symbol)||!Symbol.sham&&ht&&ht<41})),St=xt&&!Symbol.sham&&"symbol"==typeof Symbol.iterator,wt=ft,Ot=y,Et=lt,jt=Object,Rt=St?function(t){return"symbol"==typeof t}:function(t){var e=wt("Symbol");return Ot(e)&&Et(e.prototype,jt(t))},It=function(t){return null==t},Pt=N,Tt=It,Ct=function(t,e){var n=t[e];return Tt(n)?void 0:Pt(n)},_t=ut,At=y,Nt=P,kt=TypeError,Dt={exports:{}},Mt=u,$t=Object.defineProperty,Lt=function(t,e){try{$t(Mt,t,{value:e,configurable:!0,writable:!0})}catch(n){Mt[t]=e}return e},Ft=Lt,zt="__core-js_shared__",Kt=u[zt]||Ft(zt,{}),Wt=Kt;(Dt.exports=function(t,e){return Wt[t]||(Wt[t]=void 0!==e?e:{})})("versions",[]).push({version:"3.33.1",mode:"global",copyright:"© 2014-2023 Denis Pushkarev (zloirock.ru)",license:"https://github.com/zloirock/core-js/blob/v3.33.1/LICENSE",source:"https://github.com/zloirock/core-js"});var Bt=Dt.exports,Ut=It,Yt=TypeError,Ht=function(t){if(Ut(t))throw new Yt("Can't call method on "+t);return t},Vt=Ht,Gt=Object,qt=function(t){return Gt(Vt(t))},Xt=qt,Jt=p({}.hasOwnProperty),Qt=Object.hasOwn||function(t,e){return Jt(Xt(t),e)},Zt=p,te=0,ee=Math.random(),ne=Zt(1..toString),re=function(t){return"Symbol("+(void 0===t?"":t)+")_"+ne(++te+ee,36)},oe=Bt,ie=Qt,ue=re,ce=xt,ae=St,fe=u.Symbol,le=oe("wks"),se=ae?fe.for||fe:fe&&fe.withoutSetter||ue,pe=function(t){return ie(le,t)||(le[t]=ce&&ie(fe,t)?fe[t]:se("Symbol."+t)),le[t]},de=ut,ge=P,ve=Rt,ye=Ct,he=function(t,e){var n,r;if("string"===e&&At(n=t.toString)&&!Nt(r=_t(n,t)))return r;if(At(n=t.valueOf)&&!Nt(r=_t(n,t)))return r;if("string"!==e&&At(n=t.toString)&&!Nt(r=_t(n,t)))return r;throw new kt("Can't convert object to primitive value")},be=TypeError,me=pe("toPrimitive"),xe=function(t,e){if(!ge(t)||ve(t))return t;var n,r=ye(t,me);if(r){if(void 0===e&&(e="default"),n=de(r,t,e),!ge(n)||ve(n))return n;throw new be("Can't convert object to primitive value")}return void 0===e&&(e="number"),he(t,e)},Se=Rt,we=function(t){var e=xe(t,"string");return Se(e)?e:e+""},Oe=o,Ee=nt,je=rt,Re=F,Ie=we,Pe=TypeError,Te=Object.defineProperty,Ce=Object.getOwnPropertyDescriptor,_e="enumerable",Ae="configurable",Ne="writable";X.f=Oe?je?function(t,e,n){if(Re(t),e=Ie(e),Re(n),"function"==typeof t&&"prototype"===e&&"value"in n&&Ne in n&&!n[Ne]){var r=Ce(t,e);r&&r[Ne]&&(t[e]=n.value,n={configurable:Ae in n?n[Ae]:r[Ae],enumerable:_e in n?n[_e]:r[_e],writable:!1})}return Te(t,e,n)}:Te:function(t,e,n){if(Re(t),e=Ie(e),Re(n),Ee)try{return Te(t,e,n)}catch(t){}if("get"in n||"set"in n)throw new Pe("Accessors not supported");return"value"in n&&(t[e]=n.value),t};var ke=function(t,e){return{enumerable:!(1&t),configurable:!(2&t),writable:!(4&t),value:e}},De=X,Me=ke,$e=o?function(t,e,n){return De.f(t,e,Me(1,n))}:function(t,e,n){return t[e]=n,t},Le={},Fe=p,ze=Fe({}.toString),Ke=Fe("".slice),We=function(t){return Ke(ze(t),8,-1)},Be=r,Ue=We,Ye=Object,He=p("".split),Ve=Be((function(){return!Ye("z").propertyIsEnumerable(0)}))?function(t){return"String"===Ue(t)?He(t,""):Ye(t)}:Ye,Ge=Ht,qe=function(t){return Ve(Ge(t))},Xe=Math.ceil,Je=Math.floor,Qe=Math.trunc||function(t){var e=+t;return(e>0?Je:Xe)(e)},Ze=function(t){var e=+t;return e!=e||0===e?0:Qe(e)},tn=Ze,en=Math.max,nn=Math.min,rn=Ze,on=Math.min,un=function(t){return t>0?on(rn(t),9007199254740991):0},cn=un,an=qe,fn=function(t,e){var n=tn(t);return n<0?en(n+e,0):nn(n,e)},ln=function(t){return cn(t.length)},sn=function(t){return function(e,n,r){var o,i=an(e),u=ln(i),c=fn(r,u);if(t&&n!=n){for(;u>c;)if((o=i[c++])!=o)return!0}else for(;u>c;c++)if((t||c in i)&&i[c]===n)return t||c||0;return!t&&-1}},pn={includes:sn(!0),indexOf:sn(!1)},dn={},gn=Qt,vn=qe,yn=pn.indexOf,hn=dn,bn=p([].push),mn=function(t,e){var n,r=vn(t),o=0,i=[];for(n in r)!gn(hn,n)&&gn(r,n)&&bn(i,n);for(;e.length>o;)gn(r,n=e[o++])&&(~yn(i,n)||bn(i,n));return i},xn=["constructor","hasOwnProperty","isPrototypeOf","propertyIsEnumerable","toLocaleString","toString","valueOf"],Sn=mn,wn=xn.concat("length","prototype");Le.f=Object.getOwnPropertyNames||function(t){return Sn(t,wn)};var On=P,En=We,jn=pe("match"),Rn={};Rn[pe("toStringTag")]="z";var In="[object z]"===String(Rn),Pn=In,Tn=y,Cn=We,_n=pe("toStringTag"),An=Object,Nn="Arguments"===Cn(function(){return arguments}()),kn=Pn?Cn:function(t){var e,n,r;return void 0===t?"Undefined":null===t?"Null":"string"==typeof(n=function(t,e){try{return t[e]}catch(t){}}(e=An(t),_n))?n:Nn?Cn(e):"Object"===(r=Cn(e))&&Tn(e.callee)?"Arguments":r},Dn=kn,Mn=String,$n=function(t){if("Symbol"===Dn(t))throw new TypeError("Cannot convert a Symbol value to a string");return Mn(t)},Ln=F,Fn=function(){var t=Ln(this),e="";return t.hasIndices&&(e+="d"),t.global&&(e+="g"),t.ignoreCase&&(e+="i"),t.multiline&&(e+="m"),t.dotAll&&(e+="s"),t.unicode&&(e+="u"),t.unicodeSets&&(e+="v"),t.sticky&&(e+="y"),e},zn=ut,Kn=Qt,Wn=lt,Bn=Fn,Un=RegExp.prototype,Yn=function(t){var e=t.flags;return void 0!==e||"flags"in Un||Kn(t,"flags")||!Wn(Un,t)?e:zn(Bn,t)},Hn=r,Vn=u.RegExp,Gn=Hn((function(){var t=Vn("a","y");return t.lastIndex=2,null!==t.exec("abcd")})),qn=Gn||Hn((function(){return!Vn("a","y").sticky})),Xn={BROKEN_CARET:Gn||Hn((function(){var t=Vn("^r","gy");return t.lastIndex=2,null!==t.exec("str")})),MISSED_STICKY:qn,UNSUPPORTED_Y:Gn},Jn=X.f,Qn={exports:{}},Zn=o,tr=Qt,er=Function.prototype,nr=Zn&&Object.getOwnPropertyDescriptor,rr=tr(er,"name"),or={EXISTS:rr,PROPER:rr&&"something"===function(){}.name,CONFIGURABLE:rr&&(!Zn||Zn&&nr(er,"name").configurable)},ir=y,ur=Kt,cr=p(Function.toString);ir(ur.inspectSource)||(ur.inspectSource=function(t){return cr(t)});var ar,fr,lr,sr=ur.inspectSource,pr=y,dr=u.WeakMap,gr=pr(dr)&&/native code/.test(String(dr)),vr=re,yr=Bt("keys"),hr=function(t){return yr[t]||(yr[t]=vr(t))},br=gr,mr=u,xr=P,Sr=$e,wr=Qt,Or=Kt,Er=hr,jr=dn,Rr="Object already initialized",Ir=mr.TypeError,Pr=mr.WeakMap;if(br||Or.state){var Tr=Or.state||(Or.state=new Pr);Tr.get=Tr.get,Tr.has=Tr.has,Tr.set=Tr.set,ar=function(t,e){if(Tr.has(t))throw new Ir(Rr);return e.facade=t,Tr.set(t,e),e},fr=function(t){return Tr.get(t)||{}},lr=function(t){return Tr.has(t)}}else{var Cr=Er("state");jr[Cr]=!0,ar=function(t,e){if(wr(t,Cr))throw new Ir(Rr);return e.facade=t,Sr(t,Cr,e),e},fr=function(t){return wr(t,Cr)?t[Cr]:{}},lr=function(t){return wr(t,Cr)}}var _r={set:ar,get:fr,has:lr,enforce:function(t){return lr(t)?fr(t):ar(t,{})},getterFor:function(t){return function(e){var n;if(!xr(e)||(n=fr(e)).type!==t)throw new Ir("Incompatible receiver, "+t+" required");return n}}},Ar=p,Nr=r,kr=y,Dr=Qt,Mr=o,$r=or.CONFIGURABLE,Lr=sr,Fr=_r.enforce,zr=_r.get,Kr=String,Wr=Object.defineProperty,Br=Ar("".slice),Ur=Ar("".replace),Yr=Ar([].join),Hr=Mr&&!Nr((function(){return 8!==Wr((function(){}),"length",{value:8}).length})),Vr=String(String).split("String"),Gr=Qn.exports=function(t,e,n){"Symbol("===Br(Kr(e),0,7)&&(e="["+Ur(Kr(e),/^Symbol\(([^)]*)\)/,"$1")+"]"),n&&n.getter&&(e="get "+e),n&&n.setter&&(e="set "+e),(!Dr(t,"name")||$r&&t.name!==e)&&(Mr?Wr(t,"name",{value:e,configurable:!0}):t.name=e),Hr&&n&&Dr(n,"arity")&&t.length!==n.arity&&Wr(t,"length",{value:n.arity});try{n&&Dr(n,"constructor")&&n.constructor?Mr&&Wr(t,"prototype",{writable:!1}):t.prototype&&(t.prototype=void 0)}catch(t){}var r=Fr(t);return Dr(r,"source")||(r.source=Yr(Vr,"string"==typeof e?e:"")),t};Function.prototype.toString=Gr((function(){return kr(this)&&zr(this).source||Lr(this)}),"toString");var qr=Qn.exports,Xr=y,Jr=X,Qr=qr,Zr=Lt,to=function(t,e,n,r){r||(r={});var o=r.enumerable,i=void 0!==r.name?r.name:e;if(Xr(n)&&Qr(n,i,r),r.global)o?t[e]=n:Zr(e,n);else{try{r.unsafe?t[e]&&(o=!0):delete t[e]}catch(t){}o?t[e]=n:Jr.f(t,e,{value:n,enumerable:!1,configurable:!r.nonConfigurable,writable:!r.nonWritable})}return t},eo=qr,no=X,ro=ft,oo=function(t,e,n){return n.get&&eo(n.get,e,{getter:!0}),n.set&&eo(n.set,e,{setter:!0}),no.f(t,e,n)},io=o,uo=pe("species"),co=r,ao=u.RegExp,fo=co((function(){var t=ao(".","s");return!(t.dotAll&&t.test("\n")&&"s"===t.flags)})),lo=r,so=u.RegExp,po=lo((function(){var t=so("(?<a>b)","g");return"b"!==t.exec("b").groups.a||"bc"!=="b".replace(t,"$<a>c")})),go=o,vo=u,yo=p,ho=j,bo=function(t,e,n){var r,o;return q&&V(r=e.constructor)&&r!==n&&G(o=r.prototype)&&o!==n.prototype&&q(t,o),t},mo=$e,xo=Le.f,So=lt,wo=function(t){var e;return On(t)&&(void 0!==(e=t[jn])?!!e:"RegExp"===En(t))},Oo=$n,Eo=Yn,jo=Xn,Ro=function(t,e,n){n in t||Jn(t,n,{configurable:!0,get:function(){return e[n]},set:function(t){e[n]=t}})},Io=to,Po=r,To=Qt,Co=_r.enforce,_o=function(t){var e=ro(t);io&&e&&!e[uo]&&oo(e,uo,{configurable:!0,get:function(){return this}})},Ao=fo,No=po,ko=pe("match"),Do=vo.RegExp,Mo=Do.prototype,$o=vo.SyntaxError,Lo=yo(Mo.exec),Fo=yo("".charAt),zo=yo("".replace),Ko=yo("".indexOf),Wo=yo("".slice),Bo=/^\?<[^\s\d!#%&*+<=>@^][^\s!#%&*+<=>@^]*>/,Uo=/a/g,Yo=/a/g,Ho=new Do(Uo)!==Uo,Vo=jo.MISSED_STICKY,Go=jo.UNSUPPORTED_Y,qo=go&&(!Ho||Vo||Ao||No||Po((function(){return Yo[ko]=!1,Do(Uo)!==Uo||Do(Yo)===Yo||"/a/i"!==String(Do(Uo,"i"))})));if(ho("RegExp",qo)){for(var Xo=function(t,e){var n,r,o,i,u,c,a=So(Mo,this),f=wo(t),l=void 0===e,s=[],p=t;if(!a&&f&&l&&t.constructor===Xo)return t;if((f||So(Mo,t))&&(t=t.source,l&&(e=Eo(p))),t=void 0===t?"":Oo(t),e=void 0===e?"":Oo(e),p=t,Ao&&"dotAll"in Uo&&(r=!!e&&Ko(e,"s")>-1)&&(e=zo(e,/s/g,"")),n=e,Vo&&"sticky"in Uo&&(o=!!e&&Ko(e,"y")>-1)&&Go&&(e=zo(e,/y/g,"")),No&&(i=function(t){for(var e,n=t.length,r=0,o="",i=[],u={},c=!1,a=!1,f=0,l="";r<=n;r++){if("\\"===(e=Fo(t,r)))e+=Fo(t,++r);else if("]"===e)c=!1;else if(!c)switch(!0){case"["===e:c=!0;break;case"("===e:Lo(Bo,Wo(t,r+1))&&(r+=2,a=!0),o+=e,f++;continue;case">"===e&&a:if(""===l||To(u,l))throw new $o("Invalid capture group name");u[l]=!0,i[i.length]=[l,f],a=!1,l="";continue}a?l+=e:o+=e}return[o,i]}(t),t=i[0],s=i[1]),u=bo(Do(t,e),a?this:Mo,Xo),(r||o||s.length)&&(c=Co(u),r&&(c.dotAll=!0,c.raw=Xo(function(t){for(var e,n=t.length,r=0,o="",i=!1;r<=n;r++)"\\"!==(e=Fo(t,r))?i||"."!==e?("["===e?i=!0:"]"===e&&(i=!1),o+=e):o+="[\\s\\S]":o+=e+Fo(t,++r);return o}(t),n)),o&&(c.sticky=!0),s.length&&(c.groups=s)),t!==p)try{mo(u,"source",""===p?"(?:)":p)}catch(t){}return u},Jo=xo(Do),Qo=0;Jo.length>Qo;)Ro(Xo,Do,Jo[Qo++]);Mo.constructor=Xo,Xo.prototype=Mo,Io(vo,"RegExp",Xo,{constructor:!0})}_o("RegExp");var Zo={},ti={},ei={}.propertyIsEnumerable,ni=Object.getOwnPropertyDescriptor,ri=ni&&!ei.call({1:2},1);ti.f=ri?function(t){var e=ni(this,t);return!!e&&e.enumerable}:ei;var oi=o,ii=ut,ui=ti,ci=ke,ai=qe,fi=we,li=Qt,si=nt,pi=Object.getOwnPropertyDescriptor;Zo.f=oi?pi:function(t,e){if(t=ai(t),e=fi(e),si)try{return pi(t,e)}catch(t){}if(li(t,e))return ci(!ii(ui.f,t,e),t[e])};var di={};di.f=Object.getOwnPropertySymbols;var gi=ft,vi=Le,yi=di,hi=F,bi=p([].concat),mi=gi("Reflect","ownKeys")||function(t){var e=vi.f(hi(t)),n=yi.f;return n?bi(e,n(t)):e},xi=Qt,Si=mi,wi=Zo,Oi=X,Ei=u,ji=Zo.f,Ri=$e,Ii=to,Pi=Lt,Ti=function(t,e,n){for(var r=Si(e),o=Oi.f,i=wi.f,u=0;u<r.length;u++){var c=r[u];xi(t,c)||n&&xi(n,c)||o(t,c,i(e,c))}},Ci=j,_i=function(t,e){var n,r,o,i,u,c=t.target,a=t.global,f=t.stat;if(n=a?Ei:f?Ei[c]||Pi(c,{}):(Ei[c]||{}).prototype)for(r in e){if(i=e[r],o=t.dontCallGetSet?(u=ji(n,r))&&u.value:n[r],!Ci(a?r:c+(f?".":"#")+r,t.forced)&&void 0!==o){if(typeof i==typeof o)continue;Ti(i,o)}(t.sham||o&&o.sham)&&Ri(i,"sham",!0),Ii(n,r,i,t)}},Ai={},Ni=mn,ki=xn,Di=Object.keys||function(t){return Ni(t,ki)},Mi=o,$i=rt,Li=X,Fi=F,zi=qe,Ki=Di;Ai.f=Mi&&!$i?Object.defineProperties:function(t,e){Fi(t);for(var n,r=zi(e),o=Ki(e),i=o.length,u=0;i>u;)Li.f(t,n=o[u++],r[n]);return t};var Wi,Bi=ft("document","documentElement"),Ui=F,Yi=Ai,Hi=xn,Vi=dn,Gi=Bi,qi=tt,Xi="prototype",Ji="script",Qi=hr("IE_PROTO"),Zi=function(){},tu=function(t){return"<"+Ji+">"+t+"</"+Ji+">"},eu=function(t){t.write(tu("")),t.close();var e=t.parentWindow.Object;return t=null,e},nu=function(){try{Wi=new ActiveXObject("htmlfile")}catch(t){}var t,e,n;nu="undefined"!=typeof document?document.domain&&Wi?eu(Wi):(e=qi("iframe"),n="java"+Ji+":",e.style.display="none",Gi.appendChild(e),e.src=String(n),(t=e.contentWindow.document).open(),t.write(tu("document.F=Object")),t.close(),t.F):eu(Wi);for(var r=Hi.length;r--;)delete nu[Xi][Hi[r]];return nu()};Vi[Qi]=!0;var ru=Object.create||function(t,e){var n;return null!==t?(Zi[Xi]=Ui(t),n=new Zi,Zi[Xi]=null,n[Qi]=t):n=nu(),void 0===e?n:Yi.f(n,e)},ou=ut,iu=p,uu=$n,cu=Fn,au=Xn,fu=ru,lu=_r.get,su=fo,pu=po,du=Bt("native-string-replace",String.prototype.replace),gu=RegExp.prototype.exec,vu=gu,yu=iu("".charAt),hu=iu("".indexOf),bu=iu("".replace),mu=iu("".slice),xu=function(){var t=/a/,e=/b*/g;return ou(gu,t,"a"),ou(gu,e,"a"),0!==t.lastIndex||0!==e.lastIndex}(),Su=au.BROKEN_CARET,wu=void 0!==/()??/.exec("")[1];(xu||wu||Su||su||pu)&&(vu=function(t){var e,n,r,o,i,u,c,a=this,f=lu(a),l=uu(t),s=f.raw;if(s)return s.lastIndex=a.lastIndex,e=ou(vu,s,l),a.lastIndex=s.lastIndex,e;var p=f.groups,d=Su&&a.sticky,g=ou(cu,a),v=a.source,y=0,h=l;if(d&&(g=bu(g,"y",""),-1===hu(g,"g")&&(g+="g"),h=mu(l,a.lastIndex),a.lastIndex>0&&(!a.multiline||a.multiline&&"\n"!==yu(l,a.lastIndex-1))&&(v="(?: "+v+")",h=" "+h,y++),n=new RegExp("^(?:"+v+")",g)),wu&&(n=new RegExp("^"+v+"$(?!\\s)",g)),xu&&(r=a.lastIndex),o=ou(gu,d?n:a,h),d?o?(o.input=mu(o.input,y),o[0]=mu(o[0],y),o.index=a.lastIndex,a.lastIndex+=o[0].length):a.lastIndex=0:xu&&o&&(a.lastIndex=a.global?o.index+o[0].length:r),wu&&o&&o.length>1&&ou(du,o[0],n,(function(){for(i=1;i<arguments.length-2;i++)void 0===arguments[i]&&(o[i]=void 0)})),o&&p)for(o.groups=u=fu(null),i=0;i<p.length;i++)u[(c=p[i])[0]]=o[c[1]];return o});var Ou=vu;_i({target:"RegExp",proto:!0,forced:/./.exec!==Ou},{exec:Ou});var Eu=or.PROPER,ju=to,Ru=F,Iu=$n,Pu=r,Tu=Yn,Cu="toString",_u=RegExp.prototype[Cu],Au=Pu((function(){return"/a/b"!==_u.call({source:"a",flags:"b"})})),Nu=Eu&&_u.name!==Cu;(Au||Nu)&&ju(RegExp.prototype,Cu,(function(){var t=Ru(this);return"/"+Iu(t.source)+"/"+Iu(Tu(t))}),{unsafe:!0});var ku="\t\n\v\f\r                　\u2028\u2029\ufeff",Du=Ht,Mu=$n,$u=ku,Lu=p("".replace),Fu=RegExp("^["+$u+"]+"),zu=RegExp("(^|[^"+$u+"])["+$u+"]+$"),Ku=function(t){return function(e){var n=Mu(Du(e));return 1&t&&(n=Lu(n,Fu,"")),2&t&&(n=Lu(n,zu,"$1")),n}},Wu={start:Ku(1),end:Ku(2),trim:Ku(3)},Bu=or.PROPER,Uu=r,Yu=ku,Hu=Wu.trim;_i({target:"String",proto:!0,forced:function(t){return Uu((function(){return!!Yu[t]()||"​᠎"!=="​᠎"[t]()||Bu&&Yu[t].name!==t}))}("trim")},{trim:function(){return Hu(this)}});var Vu=c,Gu=Function.prototype,qu=Gu.apply,Xu=Gu.call,Ju="object"==typeof Reflect&&Reflect.apply||(Vu?Xu.bind(qu):function(){return Xu.apply(qu,arguments)}),Qu=We,Zu=p,tc=function(t){if("Function"===Qu(t))return Zu(t)},ec=to,nc=Ou,rc=r,oc=pe,ic=$e,uc=oc("species"),cc=RegExp.prototype,ac=p,fc=Ze,lc=$n,sc=Ht,pc=ac("".charAt),dc=ac("".charCodeAt),gc=ac("".slice),vc=function(t){return function(e,n){var r,o,i=lc(sc(e)),u=fc(n),c=i.length;return u<0||u>=c?t?"":void 0:(r=dc(i,u))<55296||r>56319||u+1===c||(o=dc(i,u+1))<56320||o>57343?t?pc(i,u):r:t?gc(i,u,u+2):o-56320+(r-55296<<10)+65536}},yc={codeAt:vc(!1),charAt:vc(!0)}.charAt,hc=p,bc=qt,mc=Math.floor,xc=hc("".charAt),Sc=hc("".replace),wc=hc("".slice),Oc=/\$([$&'`]|\d{1,2}|<[^>]*>)/g,Ec=/\$([$&'`]|\d{1,2})/g,jc=ut,Rc=F,Ic=y,Pc=We,Tc=Ou,Cc=TypeError,_c=Ju,Ac=ut,Nc=p,kc=function(t,e,n,r){var o=oc(t),i=!rc((function(){var e={};return e[o]=function(){return 7},7!==""[t](e)})),u=i&&!rc((function(){var e=!1,n=/a/;return"split"===t&&((n={}).constructor={},n.constructor[uc]=function(){return n},n.flags="",n[o]=/./[o]),n.exec=function(){return e=!0,null},n[o](""),!e}));if(!i||!u||n){var c=tc(/./[o]),a=e(o,""[t],(function(t,e,n,r,o){var u=tc(t),a=e.exec;return a===nc||a===cc.exec?i&&!o?{done:!0,value:c(e,n,r)}:{done:!0,value:u(n,e,r)}:{done:!1}}));ec(String.prototype,t,a[0]),ec(cc,o,a[1])}r&&ic(cc[o],"sham",!0)},Dc=r,Mc=F,$c=y,Lc=It,Fc=Ze,zc=un,Kc=$n,Wc=Ht,Bc=function(t,e,n){return e+(n?yc(t,e).length:1)},Uc=Ct,Yc=function(t,e,n,r,o,i){var u=n+t.length,c=r.length,a=Ec;return void 0!==o&&(o=bc(o),a=Oc),Sc(i,a,(function(i,a){var f;switch(xc(a,0)){case"$":return"$";case"&":return t;case"`":return wc(e,0,n);case"'":return wc(e,u);case"<":f=o[wc(a,1,-1)];break;default:var l=+a;if(0===l)return i;if(l>c){var s=mc(l/10);return 0===s?i:s<=c?void 0===r[s-1]?xc(a,1):r[s-1]+xc(a,1):i}f=r[l-1]}return void 0===f?"":f}))},Hc=function(t,e){var n=t.exec;if(Ic(n)){var r=jc(n,t,e);return null!==r&&Rc(r),r}if("RegExp"===Pc(t))return jc(Tc,t,e);throw new Cc("RegExp#exec called on incompatible receiver")},Vc=pe("replace"),Gc=Math.max,qc=Math.min,Xc=Nc([].concat),Jc=Nc([].push),Qc=Nc("".indexOf),Zc=Nc("".slice),ta="$0"==="a".replace(/./,"$0"),ea=!!/./[Vc]&&""===/./[Vc]("a","$0");kc("replace",(function(t,e,n){var r=ea?"$":"$0";return[function(t,n){var r=Wc(this),o=Lc(t)?void 0:Uc(t,Vc);return o?Ac(o,t,r,n):Ac(e,Kc(r),t,n)},function(t,o){var i=Mc(this),u=Kc(t);if("string"==typeof o&&-1===Qc(o,r)&&-1===Qc(o,"$<")){var c=n(e,i,u,o);if(c.done)return c.value}var a=$c(o);a||(o=Kc(o));var f,l=i.global;l&&(f=i.unicode,i.lastIndex=0);for(var s,p=[];null!==(s=Hc(i,u))&&(Jc(p,s),l);){""===Kc(s[0])&&(i.lastIndex=Bc(u,zc(i.lastIndex),f))}for(var d,g="",v=0,y=0;y<p.length;y++){for(var h,b=Kc((s=p[y])[0]),m=Gc(qc(Fc(s.index),u.length),0),x=[],S=1;S<s.length;S++)Jc(x,void 0===(d=s[S])?d:String(d));var w=s.groups;if(a){var O=Xc([b],x,m,u);void 0!==w&&Jc(O,w),h=Kc(_c(o,void 0,O))}else h=Yc(b,u,m,x,w,o);m>=v&&(g+=Zc(u,v,m)+h,v=m+b.length)}return g+Zc(u,v)}]}),!!Dc((function(){var t=/./;return t.exec=function(){var t=[];return t.groups={a:"7"},t},"7"!=="".replace(t,"$<a>")}))||!ta||ea);var na=p,ra=to,oa=Date.prototype,ia="Invalid Date",ua="toString",ca=na(oa[ua]),aa=na(oa.getTime);String(new Date(NaN))!==ia&&ra(oa,ua,(function(){var t=aa(this);return t==t?ca(this):ia}));var fa=kn,la=In?{}.toString:function(){return"[object "+fa(this)+"]"};In||to(Object.prototype,"toString",la,{unsafe:!0})
/*!
 * Handles finding a text string anywhere in the slides and showing the next occurrence to the user
 * by navigatating to that slide and highlighting it.
 *
 * @author Jon Snyder <snyder.jon@gmail.com>, February 2013
 */;var sa=function(){var t,e,n,r,o,i,u;function c(){(e=document.createElement("div")).classList.add("searchbox"),e.style.position="absolute",e.style.top="10px",e.style.right="10px",e.style.zIndex=10,e.innerHTML='<input type="search" class="searchinput" placeholder="Search..." style="vertical-align: top;"/>\n\t\t</span>',(n=e.querySelector(".searchinput")).style.width="240px",n.style.fontSize="14px",n.style.padding="4px 6px",n.style.color="#000",n.style.background="#fff",n.style.borderRadius="2px",n.style.border="0",n.style.outline="0",n.style.boxShadow="0 2px 18px rgba(0, 0, 0, 0.2)",n.style["-webkit-appearance"]="none",t.getRevealElement().appendChild(e),n.addEventListener("keyup",(function(e){if(13===e.keyCode)e.preventDefault(),function(){if(i){var e=n.value;""===e?(u&&u.remove(),r=null):(u=new l("slidecontent"),r=u.apply(e),o=0)}r&&(r.length&&r.length<=o&&(o=0),r.length>o&&(t.slide(r[o].h,r[o].v),o++))}(),i=!1;else i=!0}),!1),f()}function a(){e||c(),e.style.display="inline",n.focus(),n.select()}function f(){e||c(),e.style.display="none",u&&u.remove()}function l(e,n){var r=document.getElementById(e)||document.body,o=n||"EM",i=new RegExp("^(?:"+o+"|SCRIPT|FORM)$"),u=["#ff6","#a0ffff","#9f9","#f99","#f6f"],c=[],a=0,f="",l=[];this.setRegex=function(t){t=t.trim(),f=new RegExp("("+t+")","i")},this.getRegex=function(){return f.toString().replace(/^\/\\b\(|\)\\b\/i$/g,"").replace(/\|/g," ")},this.hiliteWords=function(e){if(null!=e&&e&&f&&!i.test(e.nodeName)){if(e.hasChildNodes())for(var n=0;n<e.childNodes.length;n++)this.hiliteWords(e.childNodes[n]);var r,s;if(3==e.nodeType)if((r=e.nodeValue)&&(s=f.exec(r))){for(var p=e;null!=p&&"SECTION"!=p.nodeName;)p=p.parentNode;var d=t.getIndices(p),g=l.length,v=!1;for(n=0;n<g;n++)l[n].h===d.h&&l[n].v===d.v&&(v=!0);v||l.push(d),c[s[0].toLowerCase()]||(c[s[0].toLowerCase()]=u[a++%u.length]);var y=document.createElement(o);y.appendChild(document.createTextNode(s[0])),y.style.backgroundColor=c[s[0].toLowerCase()],y.style.fontStyle="inherit",y.style.color="#000";var h=e.splitText(s.index);h.nodeValue=h.nodeValue.substring(s[0].length),e.parentNode.insertBefore(y,h)}}},this.remove=function(){for(var t,e=document.getElementsByTagName(o);e.length&&(t=e[0]);)t.parentNode.replaceChild(t.firstChild,t)},this.apply=function(t){if(null!=t&&t)return this.remove(),this.setRegex(t),this.hiliteWords(r),l}}return{id:"search",init:function(n){(t=n).registerKeyboardShortcut("CTRL + Shift + F","Search"),document.addEventListener("keydown",(function(t){"F"==t.key&&(t.ctrlKey||t.metaKey)&&(t.preventDefault(),e||c(),"inline"!==e.style.display?a():f())}),!1)},open:a}};export{sa as default};