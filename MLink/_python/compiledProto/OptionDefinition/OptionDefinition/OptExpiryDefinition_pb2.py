# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: OptionDefinition/OptExpiryDefinition.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n*OptionDefinition/OptExpiryDefinition.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xde\x05\n\x13OptExpiryDefinition\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12;\n\x04pkey\x18\x02 \x01(\x0b\x32-.spiderrock.protobuf.OptExpiryDefinition.PKey\x12.\n\x06ticker\x18\x64 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12,\n\x04\x66key\x18g \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12\x38\n\x10u_prc_driver_key\x18j \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12?\n\x15u_prc_driver_key_type\x18m \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x38\n\x10u_prc_bound_fKey\x18p \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12.\n\nexpiration\x18s \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x31\n\rmaturity_date\x18v \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x16\n\x0e\x64isplay_factor\x18y \x01(\x01\x12\x11\n\tcab_price\x18| \x01(\x01\x12\x36\n\x0cprice_format\x18\x7f \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x16\n\rmin_tick_size\x18\x82\x01 \x01(\x01\x12.\n\ttimestamp\x18\x85\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x34\n\x04PKey\x12,\n\x04\x65key\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKeyb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'OptionDefinition.OptExpiryDefinition_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_OPTEXPIRYDEFINITION']._serialized_start=126
  _globals['_OPTEXPIRYDEFINITION']._serialized_end=860
  _globals['_OPTEXPIRYDEFINITION_PKEY']._serialized_start=808
  _globals['_OPTEXPIRYDEFINITION_PKEY']._serialized_end=860
# @@protoc_insertion_point(module_scope)
