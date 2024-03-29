# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: OptProbModel/OptionQuoteProbability.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n)OptProbModel/OptionQuoteProbability.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\"\xf6\t\n\x16OptionQuoteProbability\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12>\n\x04pkey\x18\x02 \x01(\x0b\x32\x30.spiderrock.protobuf.OptionQuoteProbability.PKey\x12\r\n\x05u_mid\x18\x64 \x01(\x01\x12\r\n\x05u_prc\x18g \x01(\x01\x12\x11\n\tbid_price\x18j \x01(\x02\x12\x11\n\task_price\x18m \x01(\x02\x12\x10\n\x08\x62id_size\x18p \x01(\x05\x12\x10\n\x08\x61sk_size\x18s \x01(\x05\x12\x15\n\rbid_take_prob\x18v \x01(\x02\x12\x15\n\rask_take_prob\x18y \x01(\x02\x12\x37\n\x0b\x62id_take_rv\x18| \x01(\x0e\x32\".spiderrock.protobuf.PredictResult\x12\x37\n\x0b\x61sk_take_rv\x18\x7f \x01(\x0e\x32\".spiderrock.protobuf.PredictResult\x12\x17\n\x0e\x62id_impr_price\x18\x82\x01 \x01(\x02\x12\x17\n\x0e\x61sk_impr_price\x18\x85\x01 \x01(\x02\x12\x17\n\x0e\x62id_tk_im_prob\x18\x88\x01 \x01(\x02\x12\x17\n\x0e\x61sk_tk_im_prob\x18\x8b\x01 \x01(\x02\x12\x39\n\x0c\x62id_tk_im_rv\x18\x8e\x01 \x01(\x0e\x32\".spiderrock.protobuf.PredictResult\x12\x39\n\x0c\x61sk_tk_im_rv\x18\x91\x01 \x01(\x0e\x32\".spiderrock.protobuf.PredictResult\x12\x13\n\nsurf_price\x18\x94\x01 \x01(\x01\x12\x11\n\x08surf_vol\x18\x97\x01 \x01(\x01\x12\r\n\x04sdiv\x18\x9a\x01 \x01(\x01\x12\x16\n\rsurf_buy_prob\x18\x9d\x01 \x01(\x02\x12\x17\n\x0esurf_sell_prob\x18\xa0\x01 \x01(\x02\x12\x36\n\tb_surf_rv\x18\xa3\x01 \x01(\x0e\x32\".spiderrock.protobuf.PredictResult\x12\x36\n\ts_surf_rv\x18\xa6\x01 \x01(\x0e\x32\".spiderrock.protobuf.PredictResult\x12\r\n\x04vega\x18\xa9\x01 \x01(\x02\x12\x0e\n\x05\x64\x65lta\x18\xac\x01 \x01(\x02\x12\x12\n\tmid_price\x18\xaf\x01 \x01(\x02\x12\x18\n\x0f\x61vg_bid_link10m\x18\xb2\x01 \x01(\x02\x12\x18\n\x0fmae_bid_link10m\x18\xb5\x01 \x01(\x02\x12\x18\n\x0f\x61vg_ask_link10m\x18\xb8\x01 \x01(\x02\x12\x18\n\x0fmae_ask_link10m\x18\xbb\x01 \x01(\x02\x12\x19\n\x10\x61vg_mkt_width10m\x18\xbe\x01 \x01(\x02\x12\x10\n\x07\x63ounter\x18\xc1\x01 \x01(\x05\x12\x31\n\tqp_source\x18\xc4\x01 \x01(\x0e\x32\x1d.spiderrock.protobuf.QPSource\x12\x16\n\rsrc_timestamp\x18\xc7\x01 \x01(\x03\x12\x16\n\rnet_timestamp\x18\xca\x01 \x01(\x03\x12\x16\n\rsms_timestamp\x18\xcd\x01 \x01(\x03\x1aj\n\x04PKey\x12,\n\x04okey\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\x0bstate_model\x18\x0b \x01(\x0e\x32\x1f.spiderrock.protobuf.StateModelb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'OptProbModel.OptionQuoteProbability_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_OPTIONQUOTEPROBABILITY']._serialized_start=92
  _globals['_OPTIONQUOTEPROBABILITY']._serialized_end=1362
  _globals['_OPTIONQUOTEPROBABILITY_PKEY']._serialized_start=1256
  _globals['_OPTIONQUOTEPROBABILITY_PKEY']._serialized_end=1362
# @@protoc_insertion_point(module_scope)
