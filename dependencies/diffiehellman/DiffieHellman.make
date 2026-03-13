if ENABLE_DEBUG
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -unsafe -warn:4 -optimize- -debug -define:DEBUG
ASSEMBLY = bin/Debug/DiffieHellman.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug/

DIFFIEHELLMAN_DLL_MDB_SOURCE=bin/Debug/DiffieHellman.dll.mdb
DIFFIEHELLMAN_DLL_MDB=$(BUILD_DIR)/DiffieHellman.dll.mdb

endif

if ENABLE_RELEASE
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -unsafe -warn:4 -optimize-
ASSEMBLY = bin/Release/DiffieHellman.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release/

DIFFIEHELLMAN_DLL_MDB=

endif

AL=al2
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(DIFFIEHELLMAN_DLL_MDB)  

LINUX_PKGCONFIG = \
	$(DIFFIEHELLMAN_PC)  


RESGEN=resgen2
	
all: $(ASSEMBLY) $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

FILES = \
	src/AssemblyInfo.cs \
	src/mono/BigInteger.cs \
	src/mono/ConfidenceFactor.cs \
	src/mono/MiniParser.cs \
	src/mono/NextPrimeFinder.cs \
	src/mono/PrimalityTests.cs \
	src/mono/PrimeGeneratorBase.cs \
	src/mono/SecurityParser.cs \
	src/mono/SequentialSearchPrimeGeneratorBase.cs \
	src/DHKeyGeneration.cs \
	src/DHParameters.cs \
	src/DiffieHellman.cs \
	src/DiffieHellmanManaged.cs \
	src/TestApp.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	diffiehellman.pc.in \
	diffiehellman.spec.in \
	diffiehellman.snk

REFERENCES =  \
	System \
	System.Data \
	System.Xml

DLL_REFERENCES = 

CLEANFILES = $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

include $(top_srcdir)/Makefile.include

DIFFIEHELLMAN_PC_NAME = diffiehellman.pc
DIFFIEHELLMAN_PC = $(BUILD_DIR)/$(DIFFIEHELLMAN_PC_NAME)

$(eval $(call emit-deploy-wrapper,DIFFIEHELLMAN_PC,diffiehellman.pc))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'

$(ASSEMBLY_MDB): $(ASSEMBLY)

$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	mkdir -p $(shell dirname $(ASSEMBLY))
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)

install: $(BINARIES) install-dirs install-bin install-data

install-data:
	install -m 0644 $(DIFFIEHELLMAN_PC) $(DESTDIR)$(libdir)/pkgconfig/$(DIFFIEHELLMAN_PC_NAME)

install-dirs:
	 install -d -m 0755 $(DESTDIR)$(libdir)/pkgconfig

install-bin:
	$(GACUTIL) /i $(ASSEMBLY) /f /package $(ASSEMBLY_PACKAGE) /root $(DESTDIR)$(libdir)

uninstall: uninstall-bin uninstall-data

uninstall-bin:
	$(GACUTIL) /u $(ASSEMBLY) /package $(ASSEMBLY_PACKAGE) /root $(DESTDIR)$(libdir)

uninstall-data:
	rm -f $(DESTDIR)$(libdir)/pkgconfig/$(DIFFIEHELLMAN_PC_NAME)
