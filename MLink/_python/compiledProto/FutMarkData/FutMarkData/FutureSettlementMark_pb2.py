# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: FutMarkData/FutureSettlementMark.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n&FutMarkData/FutureSettlementMark.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xaa\x03\n\x14\x46utureSettlementMark\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12<\n\x04pkey\x18\x02 \x01(\x0b\x32..spiderrock.protobuf.FutureSettlementMark.PKey\x12\x31\n\x0bsettle_date\x18\x64 \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x11\n\tsettle_px\x18g \x01(\x01\x12\x12\n\nlow_lmt_px\x18j \x01(\x01\x12\x13\n\x0bhigh_lmt_px\x18m \x01(\x01\x12\x10\n\x08open_int\x18p \x01(\x05\x12\x0e\n\x06volume\x18s \x01(\x05\x12)\n\x05\x65\x61rly\x18v \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12-\n\ttimestamp\x18y \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x34\n\x04PKey\x12,\n\x04\x66key\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKeyb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'FutMarkData.FutureSettlementMark_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_FUTURESETTLEMENTMARK']._serialized_start=122
  _globals['_FUTURESETTLEMENTMARK']._serialized_end=548
  _globals['_FUTURESETTLEMENTMARK_PKEY']._serialized_start=496
  _globals['_FUTURESETTLEMENTMARK_PKEY']._serialized_end=548
# @@protoc_insertion_point(module_scope)
