# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: EquityDefinition/ExchSecurityDefinition.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n-EquityDefinition/ExchSecurityDefinition.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\"\xfd\x02\n\x16\x45xchSecurityDefinition\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12>\n\x04pkey\x18\x02 \x01(\x0b\x32\x30.spiderrock.protobuf.ExchSecurityDefinition.PKey\x12\x37\n\x10primary_currency\x18\x64 \x01(\x0e\x32\x1d.spiderrock.protobuf.Currency\x12\x0c\n\x04isin\x18\x65 \x01(\t\x12\x36\n\x0eprimary_ticker\x18\x66 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x1ao\n\x04PKey\x12\x37\n\x0f\x65xchange_ticker\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12.\n\x08\x65xchange\x18\x0b \x01(\x0e\x32\x1c.spiderrock.protobuf.StkExchb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'EquityDefinition.ExchSecurityDefinition_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_EXCHSECURITYDEFINITION']._serialized_start=96
  _globals['_EXCHSECURITYDEFINITION']._serialized_end=477
  _globals['_EXCHSECURITYDEFINITION_PKEY']._serialized_start=366
  _globals['_EXCHSECURITYDEFINITION_PKEY']._serialized_end=477
# @@protoc_insertion_point(module_scope)
