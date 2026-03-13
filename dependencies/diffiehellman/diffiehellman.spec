Name:		diffiehellman
Version:	1.0.0
Release:	0%{?dist}
Summary:	A .NET implementation of Diffie-Hellman cryptography algorithm

Group:		Development/Libraries
License:	MIT X11
URL:		http://www.mentalis.org/soft/class.qpx?id=15
Source0:	diffiehellman-1.0.0.tar.bz2
BuildRoot:	%(mktemp -ud %{_tmppath}/%{name}-%{version}-%{release}-XXXXXX)

BuildRequires:	/usr/bin/mcs
BuildRequires:	/usr/bin/gacutil
Requires:	mono-core

%description
The cryptography classes of the .NET framework lack one crucial class: an implementation of the Diffie-Hellman key agreement algorithm. To fill this gap, we created a completely managed Diffie-Hellman implementation, based on mono::'s BigInteger class.

%prep
%setup -q


%build
%configure
make


%install
rm -rf $RPM_BUILD_ROOT
make install DESTDIR=$RPM_BUILD_ROOT

%clean
rm -rf $RPM_BUILD_ROOT

%files
%defattr(-,root,root,-)
%doc license.txt Org.Mentalis.Security.Cryptography.chm
%{_libdir}/mono
%{_libdir}/pkgconfig/diffiehellman.pc

%changelog
* Mon Apr 25 2011 Maik Greubel <greubel@nkey.de> 1.0.0.0
- The initial version of package
